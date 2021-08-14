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

#Self defined
from compute_vec import *

# Import Openpose
dir_path = os.path.dirname(os.path.realpath(__file__))
try:
    # Windows Import
    if platform == "win32":
        # Change these variables to point to the correct folder (Release/x64 etc.) 
        sys.path.append(dir_path + '/../../openpose/build/python/openpose/Release');
        os.environ['PATH']  = os.environ['PATH'] + ';' + dir_path + '/../../openpose/build/x64/Release;' +  dir_path + '/../../bin;'
        import pyopenpose as op
    else:
        # Change these variables to point to the correct folder (Release/x64 etc.) 
        sys.path.append('../../openpose/build/python');
        # If you run `make install` (default path is `/usr/local/python` for Ubuntu), you can also access the OpenPose/python module from there. This will install OpenPose and the python library at your desired installation path. Ensure that this is in your python path in order to use it.
        # sys.path.append('/usr/local/python')
        from openpose import pyopenpose as op
except ImportError as e:
    print('Error: OpenPose library could not be found. Did you enable `BUILD_PYTHON` in CMake and have this Python script in the right folder?')
    raise e

# Flags
parser = argparse.ArgumentParser()
parser.add_argument("--image_path", default="../ProjectPicData", help="Process an image. Read all standard formats (jpg, png, bmp, etc.).")
args = parser.parse_known_args()

# Custom Params (refer to include/openpose/flags.hpp for more parameters)
params = dict()
params["model_folder"] = "../openpose/models/"





##################################code starts here#########################################
# Has a bug: You have to press q near the end of the video to generate the csv file.
# Doesn't matter at this point.

# Name the videos in your folder to "up.mp4", "down.mp4" and etc.
cap = cv2.VideoCapture('../TrainingVideos/Hover.mp4') # 22 circles

try:
    # Starting OpenPose
    opWrapper = op.WrapperPython()
    opWrapper.configure(params)
    opWrapper.start()

    # Set Path
    path = args[0].image_path

    # Concatenating Body Keypoints
    all_vec = []

    # Set a timer, capture every 0.05 second. Avoid redundancy.
    then = time.time()
    counter = 0
    while cap.isOpened():

        ret, frame = cap.read()
        if ret == False:
            break
        #cv2.imshow('window-name', frame)
        if time.time()-then >= 0.05:
            counter += 1
            then = time.time()
            datum = op.Datum()
            datum.cvInputData = frame
            opWrapper.emplaceAndPop([datum])

            # Capture only right hand and right elbow. which are index 3 and 4
            temp = datum.poseKeypoints[0, 3:5, 0:2]
            if(len(temp) != 0 and temp[0,0] != None and temp[0,1] != None):
                all_vec.append(np.reshape(temp, 2*len(temp)))
            cv2.imshow("Capturing: ", datum.cvOutputData)

        if cv2.waitKey(10) & 0xFF == ord('q'):
            break

    cap.release()
    cv2.destroyAllWindows()

    all_vec = pd.DataFrame(all_vec)
    # Change the corresponding gestures
    all_vec['Mot_Type'] = "Hover"
    all_vec.to_csv('./TrainingData2/Hover.csv')
    print(all_vec.head())
    print(all_vec.shape, "Hover\n")


except Exception as e:
    print(e)
    sys.exit(-1)




