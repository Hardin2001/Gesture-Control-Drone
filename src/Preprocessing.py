import pandas as pd
import numpy as np
import os
import glob
from keras.utils import to_categorical

# Reading in precalculated vectors from TrainingVec folder.
# Note that the working directory should always be set as the root folder
np.random.seed(0)
directory = os.path.join("./TrainingData2/")
all_files = glob.glob(directory + "*")
num_output = len(all_files)

# File order and gesture numbering currently is determined by the default filesystem order(by name). That is:
# 0 down
# 1 follow
# 2 left
# 3 none
# 4 right
# 5 up
# These mappings are stored in ges_types and can be access later
df = []
ges_types = {}
counter = 0
for file in all_files:
    temp = pd.read_csv(file)
    ges_types[counter] = temp['Ges_Type'][0]
    if 'none' == temp['Ges_Type'][0]:
        ges_types[counter] = "Not A Registered Gesture"
    temp['Ges_Type'] = counter
    df.append(temp)
    counter = counter + 1
df = pd.concat(df, ignore_index = True)
df = df.drop(df.columns[0], axis = 1)
df = df.dropna()

# random shuffle. Testing split = 20%
df = df.sample(frac=1, random_state=0)
ts = 0.2
ts = int(len(df)*ts)
train = df[:-ts]
test = df[-ts:]

# Create Variables needed
x_train = train.drop(columns='Ges_Type')
x_train = x_train.values
y_train = train['Ges_Type']
x_test = test.drop(columns='Ges_Type')
x_test = x_test.values
y_test = test['Ges_Type']
y_train = to_categorical(y_train,num_output,dtype=int)
y_test = to_categorical(y_test,num_output,dtype=int)
n = len(df.columns) - 1