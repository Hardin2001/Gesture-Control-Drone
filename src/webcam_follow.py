# From Python
# It requires OpenCV installed for Python
import sys
import cv2
import os
import time
from sys import platform
import numpy as np
import pandas as pd
import argparse
from MouseControl.MouseFunctions import *
#Self defined
from src.compute_vec import *
from src.config import *

##################################code starts here#########################################
video = cv2.VideoCapture(0)

check, frame = video.read()
font                   = cv2.FONT_HERSHEY_SIMPLEX
upperRightCorner = (600,50)
y0 = 30
yd = 30
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
    all_noseX= []
    all_noseY = []
    datum = op.Datum()
    then = time.time()
    gestureStrX = "Adjustment: Stay"
    gestureStrY = "Adjustment: Stay"
    gestureStrZ = "Adjustment: Stay"
    mouseQuery = ChannelQuery()
    while True:
        check, frame = video.read()
        if time.time()-then >= 0.05:
            then = time.time()
            datum.cvInputData = frame
            opWrapper.emplaceAndPop([datum])
            outputShape = datum.poseKeypoints.shape
            cvOutputData = datum.cvOutputData

            if (len(outputShape) == 0 or outputShape[0] == 0 or outputShape[1] == 0):
                cv2.putText(cvOutputData, "Gesture: No Body Detected",
                            (10,y0),
                            font,
                            fontScale,
                            fontColor,
                            lineType)
                cv2.imshow("Capturing:", cvOutputData)
                if cv2.waitKey(10) & 0xFF == ord('q'):
                    break
                continue
            # Compute Vectors
            if not datum.poseKeypoints.any():
                print("None\n")
            else:
                temp = computeNeck(datum.poseKeypoints[0, 0:, 0:2])
                noseX = datum.poseKeypoints[0, 0, 0]
                noseY = datum.poseKeypoints[0, 0, 1]
                all_vec.append(temp)
                all_noseX.append(noseX)
                all_noseY.append(noseY)
                if len(all_vec) >= 10 and outputShape[0] == 1:
                    all_vec = np.array(all_vec)
                    all_noseX = np.array(all_noseX)
                    all_noseY = np.array(all_noseY)
                    meanNeck = np.mean(all_vec)
                    meanNoseX = np.mean(all_noseX)
                    meanNoseY = np.mean(all_noseY)
                    leftBoundary = 0.30 * cvOutputData.shape[1]
                    rightBoundary = 0.70 * cvOutputData.shape[1]

                    if meanNoseX < leftBoundary:
                        rotateStr = "Adjustment: Rotate Left"
                        mouseQuery.ChannelRight(4)
                    elif meanNoseX > rightBoundary:
                        rotateStr = "Adjustment: Rotate Right"
                        mouseQuery.ChannelLeft(4)
                    else:
                        rotateStr = "Adjustment: Stay"
                        mouseQuery.resetChannel(4)
                    # if meanNoseY < 100:
                    #     gestureStrY = "Y Direction: Move Up"
                    #     mouseQuery.ChannelRight(2)
                    # elif meanNoseY > 250:
                    #     gestureStrY = "Y Direction: Move Down"
                    #     mouseQuery.ChannelLeft(2)
                    # else:
                    #     gestureStrY = "Y Direction: Stay"
                    #     mouseQuery.reset(2)
                    if meanNeck < 100:
                         gestureStrZ = "Adjustment: Move Forward"
                         mouseQuery.ChannelRight(3)
                    elif meanNeck > 250:
                         gestureStrZ = "Adjustment: Move Back"
                         mouseQuery.ChannelLeft(3)
                    else:
                         gestureStrZ = "Adjustment: Stay"
                         mouseQuery.resetChannel(3)

                    all_vec = []
                    all_noseX = []
                    all_noseY = []
                cv2.putText(cvOutputData, gestureStrX,
                        (10, y0),
                        font,
                        fontScale,
                        fontColor,
                        lineType)
                cv2.putText(cvOutputData, gestureStrZ,
                            (10, y0 + 2*yd),
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
            break

    #cap.release()
    cv2.destroyAllWindows()


except Exception as e:
    print(e)
    sys.exit(-1)




