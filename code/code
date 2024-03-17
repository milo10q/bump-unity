!pip install ucimlrepo
!pip install umap-learn
import pandas as pd
import matplotlib.pyplot as plt
import seaborn as sns
from sklearn.preprocessing import StandardScaler
from sklearn.model_selection import train_test_split
from sklearn.linear_model import LogisticRegression
from sklearn.tree import DecisionTreeClassifier
from sklearn.ensemble import RandomForestClassifier, GradientBoostingClassifier
from sklearn.svm import SVC
from sklearn.neural_network import MLPClassifier
from sklearn.metrics import accuracy_score
from sklearn.model_selection import GridSearchCV
import joblib
from google.colab import drive


from ucimlrepo import fetch_ucirepo

# fetch dataset from the repository
maternal_health_risk = fetch_ucirepo(id=863)

# data (as pandas dataframes)
X = maternal_health_risk.data.features
y = maternal_health_risk.data.targets

# metadata - our data about data
print(maternal_health_risk.metadata)

# variable information
print(maternal_health_risk.variables)

# Combine features and target into a single DataFrame
data = pd.concat([X, y], axis=1)


# Scale and normalise the data ready for training the model
# Separate the features and the target variable
X = data.iloc[:, :-1]  # All features
y = data['RiskLevel']  # Target variable

# Initialize the StandardScaler
scaler = StandardScaler()

# Fit and transform the features
X_scaled = scaler.fit_transform(X)

# Convert the scaled features back to a DataFrame
X_scaled_df = pd.DataFrame(X_scaled, columns=X.columns)

# Display the first 5 rows of the scaled features
print(X_scaled_df.head())

import numpy as np
import pandas as pd
# Mount Google Drive
drive.mount('/content/drive')

# TRAIN A RANDOM FOREST MODEL

# Separate the features and the target variable
X = data.drop('RiskLevel', axis=1)  # Drop the target column to get the features
y = data['RiskLevel']  # Target variable

# Split the data into training and test sets
X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.2, random_state=42)

# Initialize the RandomForestClassifier
random_forest = RandomForestClassifier(n_estimators=100, random_state=42)

# Fit the model to the training data
random_forest.fit(X_train, y_train)

# Make predictions on the test set
y_pred = random_forest.predict(X_test)

# Evaluate the model's performance
accuracy = accuracy_score(y_test, y_pred)
print(f'Accuracy of the Random Forest model: {accuracy:.4f}')

# Save the trained model to a file
model_file_path = '/content/drive/MyDrive/modelstuff/random_forest_model.pkl'
joblib.dump(random_forest, model_file_path)
print(f'Trained model saved to: {model_file_path}')
