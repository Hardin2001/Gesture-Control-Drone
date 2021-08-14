# From Python
# It requires OpenCV installed for Python
import sys
import cv2
import os
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


# Parameter to change: How many pictures are in your ProjectPicData Folder
# Name the pic in your folder to "0.jpg", "1.jpg" and etc.
numOfPics = 1
try:
    # Starting OpenPose
    opWrapper = op.WrapperPython()
    opWrapper.configure(params)
    opWrapper.start()

    # Set Path
    path = args[0].image_path

    all_vec = []

    # Iterate through the ProjectPicData Folder
    for i in range(0, numOfPics):
        img_path = path + '/'+ str(i) + '.jpg'
        print(img_path)

        # Process Image
        datum = op.Datum()
        imageToProcess = cv2.imread(img_path)
        datum.cvInputData = imageToProcess
        opWrapper.emplaceAndPop([datum])

        # Display Image. Uncomment below to see what happened.
        #print("Body keypoints: \n" + str(datum.poseKeypoints))
        cv2.imshow("Generating Data", datum.cvOutputData)
        cv2.waitKey(0)

        print("data: ", (datum.poseKeypoints[0,0:,0:2]), "\n")
        #print(datum.poseKeypoints)
        temp = computeVec(datum.poseKeypoints[0,0:,0:2])
        all_vec.append(np.reshape(temp, len(temp)))

except Exception as e:
    print(e)
    sys.exit(-1)

all_vec = pd.DataFrame(all_vec)
print("\n")
print(all_vec.head)
# Assume the data generated here are all type 0 for now.
# Avoid manually label.
# Later change it when generating different gestures.
# all_keypoints['Ges_Type'] = 0
all_vec.to_csv('body_keypoints.csv')
