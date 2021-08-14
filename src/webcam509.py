# From Python
# It requires OpenCV installed for Python
import sys
import cv2
import time
import numpy as np
from keras.models import load_model
#Self defined
from src.compute_vec import *
from src.Preprocessing509 import ges_types
from src.config import *
from MouseControl.MouseFunctions import *
def predictLive(cameraIndex):

    ##################################code starts here#########################################
    video = cv2.VideoCapture(cameraIndex)
    model = load_model('model509b.h5')

    check, frame = video.read()
    font                   = cv2.FONT_HERSHEY_SIMPLEX
    upperLeftCorner = (10,50)
    upperLeftCorner2 = (10,100)
    upperRightCorner = (600,50)
    fontScale              = 1
    fontColor              = (0,0,255)
    lineType               = 2

    try:
        # Starting OpenPose
        opWrapper = op.WrapperPython()
        opWrapper.configure(params)
        opWrapper.start()
        # Concatenating Body Keypoints
        all_vec = []
        datum = op.Datum()
        then = time.time()
        gestureStr = "Gesture: None"
        neck_vec = []
        all_noseX = []
        all_noseY = []
        rotateStr = "Adjustment: Stay"
        mouseQuery = ChannelQuery()
        prev = " "
        while True:
            check, frame = video.read()
            #cv2.imshow('window-name', frame)
            #ret, frame = cap.read()
            if time.time()-then >= 0.05:
                then = time.time()
                datum.cvInputData = frame
                opWrapper.emplaceAndPop([datum])
                outputShape = datum.poseKeypoints.shape
                cvOutputData = datum.cvOutputData
                if (len(outputShape) == 0 or outputShape[0] == 0 or outputShape[1] == 0):
                    cv2.putText(cvOutputData, "Gesture: No Body Detected",
                                upperLeftCorner,
                                font,
                                fontScale,
                                fontColor,
                                lineType)
                    cv2.imshow("Capturing:", cvOutputData)
                    if cv2.waitKey(10) & 0xFF == ord('q'):
                        mouseQuery.closeWindow()
                        #mouseQuery.resetAll()
                        break
                    continue

                # Compute Vectors
                if not datum.poseKeypoints.any():
                    print("None\n")
                else:

                    temp = computeShoulder(datum.poseKeypoints[0, 0:, 0:2])
                    noseX = datum.poseKeypoints[0, 0, 0]
                    noseY = datum.poseKeypoints[0, 0, 1]
                    neck_vec.append(temp)
                    all_noseX.append(noseX)
                    all_noseY.append(noseY)
                    if len(neck_vec) >= 10 and outputShape[0] == 1:
                        leftBoundary = 0.30 * cvOutputData.shape[1]
                        rightBoundary = 0.70 * cvOutputData.shape[1]
                        neck_vec = np.array(neck_vec)
                        all_noseX = np.array(all_noseX)
                        all_noseY = np.array(all_noseY)
                        meanNeck = np.mean(neck_vec)
                        meanNoseX = np.mean(all_noseX)
                        meanNoseY = np.mean(all_noseY)
                        #print(meanNoseX)
                        if meanNoseX < leftBoundary:
                            rotateStr = "Adjustment: Rotate Left"
                            mouseQuery.ChannelRight(4)
                        elif meanNoseX > rightBoundary:
                            rotateStr = "Adjustment: Rotate Right"
                            mouseQuery.ChannelLeft(4)
                        else:
                            rotateStr = "Adjustment: Stay"
                            mouseQuery.resetChannel(4)

                        if meanNeck > cvOutputData.shape[1] * 0.4:
                            rotateStr += " Stopping"
                            mouseQuery.ChannelLeft(3)


                        neck_vec = []
                        all_noseX = []
                        all_noseY = []


                    temp = computeVec(datum.poseKeypoints[0, 0:, 0:2])
                    all_vec.append(np.reshape(temp, len(temp)))
                    if len(all_vec) >= 10:
                        all_vec = np.array(all_vec)
                        pred = model.predict_classes(all_vec)
                        counts = np.bincount(pred)
                        ges = np.argmax(counts)
                        if np.mean(all_vec[:,3]) == 0 and np.mean(all_vec[:,6]) == 0:
                            gestureStr = "Gesture: No Arms Detected"
                            rotateStr += " Stopping"
                            ges = -1
                        elif max(counts) <= 6:
                            gestureStr = "Gesture: Not A Registered Gesture"
                            ges = -1
                            mouseQuery.resetAll()
                        else:
                            gestureStr = "Gesture: " + ges_types[ges]
                        all_vec = []

                        if ges != -1 and prev != ges_types[ges]:
                            mouseQuery.resetAll()
                            if ges_types[ges] == "LeftTurn":
                                #pass
                                mouseQuery.ChannelLeft(4)

                            elif ges_types[ges] == "RightTurn":
                                #pass
                                mouseQuery.ChannelRight(4)
                            elif ges_types[ges] == "Left":
                                mouseQuery.ChannelLeft(2)
                            elif ges_types[ges] == "Right":
                                mouseQuery.ChannelRight(2)
                            elif ges_types[ges] == "Forward":
                                #pass
                                mouseQuery.ChannelRight(3)
                            elif ges_types[ges] == "Back":
                                #pass
                                mouseQuery.ChannelLeft(3)
                            prev = ges_types[ges]

                    cv2.putText(cvOutputData, gestureStr,
                            upperLeftCorner,
                            font,
                            fontScale,
                            fontColor,
                            lineType)
                    cv2.putText(cvOutputData, rotateStr,
                                upperLeftCorner2,
                                font,
                                fontScale,
                                fontColor,
                                lineType)
                    cv2.putText(cvOutputData, str(outputShape[0]),
                                upperRightCorner,
                                font,
                                fontScale,
                                fontColor,
                                lineType)
                cv2.imshow("Capturing:", cvOutputData)
            if cv2.waitKey(10) & 0xFF == ord('q'):
                mouseQuery.closeWindow()
                break

        #cap.release()
        cv2.destroyAllWindows()


    except Exception as e:
        print(e)
        sys.exit(-1)




