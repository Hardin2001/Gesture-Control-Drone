# From Python
# It requires OpenCV installed for Python
import sys
import cv2
import time
import numpy as np
from keras.models import load_model
#Self defined
from src.compute_vec import computeVec
from src.Preprocessing import ges_types
from src.config import *
from MouseControl.MouseFunctions import *
def predictLive():

    ##################################code starts here#########################################
    video = cv2.VideoCapture(0)
    model = load_model('model3.h5')

    check, frame = video.read()
    font                   = cv2.FONT_HERSHEY_SIMPLEX
    upperLeftCorner = (10,50)
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
                    temp = computeVec(datum.poseKeypoints[0, 0:, 0:2])
                    all_vec.append(np.reshape(temp, len(temp)))
                    if len(all_vec) >= 10:
                        all_vec = np.array(all_vec)
                        pred = model.predict_classes(all_vec)
                        counts = np.bincount(pred)
                        ges = np.argmax(counts)
                        if np.mean(all_vec[:,3]) == 0 and np.mean(all_vec[:,6]) == 0:
                            gestureStr = "Gesture: No Arms Detected"
                            ges = -1
                            mouseQuery.resetAll()
                        else:
                            gestureStr = "Gesture: " + ges_types[ges]
                        all_vec = []

                        if ges != -1 and prev != ges_types[ges]:
                            mouseQuery.resetAll()
                            if ges_types[ges] == "down":
                                mouseQuery.ChannelLeft(3)
                            elif ges_types[ges] == "up":
                                mouseQuery.ChannelRight(3)
                            elif ges_types[ges] == "left":
                                mouseQuery.ChannelRight(2)
                            elif ges_types[ges] == "right":
                                mouseQuery.ChannelLeft(2)
                            prev = ges_types[ges]

                    cv2.putText(cvOutputData, gestureStr,
                            upperLeftCorner,
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




