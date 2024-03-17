import pandas as pd
import joblib
from google.colab import drive

def checkFeatures(featureList):
    # There must be six features
    if len(featureList) != 6:
        return False

    # Suitable Data Values for features
    suitableRanges = [
    [0,120],
    [60,220],
    [40,120],
    [3,25],
    [80,110],
    [55,120]
    ]

    # Check each feature is within range
    for i in range(6):
        if suitableRanges[i][0] > featureList[i] or featureList[i] > suitableRanges[i][1]:
            return False
    return True

def determineRisk(features,featureNames):
    # Load the trained model
    model_path = '/content/drive/MyDrive/modelstuff/random_forest_model.pkl'
    random_forest = joblib.load(model_path)

    # Make predictions for the given features
    df = pd.DataFrame([features], columns=featureNames)
    prediction = random_forest.predict(df)
    print(f"You are predicted to be at {prediction[0]}")
    return prediction[0]

def addToDatabase(featureList, featureNames, spreadSheet):
    finalStats = featureList
    finalStats.append(determineRisk(featureList,featureNames))
    sheet.loc[len(sheet.index)] = finalStats
    return sheet

drive.mount('/content/drive')

sheet = pd.read_excel("/content/drive/MyDrive/databases/Maternal Health Risk Data Set.xlsx")
sheet.head()

features_to_predict = [int(input("Input Age: ")), int(input("Input SystolicBP: ")), int(input("Input DiastolicBP: ")), float(input("Input BS: ")), int(input("Input BodyTemp: ")), int(input("Input HeartRate: "))]
feature_names = ['Age', 'SystolicBP', 'DiastolicBP', 'BS', 'BodyTemp', 'HeartRate']

if checkFeatures(features_to_predict):
    sheet = addToDatabase(features_to_predict,feature_names,sheet)
    sheet.to_excel("/content/drive/MyDrive/databases/Maternal Health Risk Data Set.xlsx", index=False)
else:
    print("Invalid Data")
