# Helper function to compute vector
import pandas as pd
import numpy as np
import math
def computeVec (keypoints):
    vec0 = keypoints[0] - keypoints[1]
    vec1 = keypoints[1] - keypoints[2]
    vec2 = keypoints[2] - keypoints[3]
    vec3 = keypoints[3] - keypoints[4]
    vec4 = keypoints[1] - keypoints[5]
    vec5 = keypoints[5] - keypoints[6]
    vec6 = keypoints[6] - keypoints[7]
    vec7 = keypoints[1] - keypoints[8]
    vec8 = keypoints[8] - keypoints[9]
    vec9 = keypoints[9] - keypoints[10]
    vec10 = keypoints[10] - keypoints[11]
    vec11 = keypoints[8] - keypoints[12]
    vec12 = keypoints[12] - keypoints[13]
    vec13 = keypoints[13] - keypoints[14]
    vec_all = np.stack((vec0, vec1, vec2, vec3, vec4, vec5, vec6, vec7, vec8, vec9, vec10, vec11, vec12, vec13))
    vec = np.zeros(14)
    for i in range(0, 14):
        vec[i] = math.degrees(math.atan2(vec_all[i,1], vec_all[i,0]))
    return vec

def computeNeck (keypoints):
    vec0 = keypoints[0] - keypoints[1]
    return math.sqrt(math.pow(vec0[0], 2) + math.pow(vec0[1], 2))

def computeShoulder(keypoints):
    vec0 = keypoints[2] - keypoints[5]
    return math.sqrt(math.pow(vec0[0], 2) + math.pow(vec0[1], 2))