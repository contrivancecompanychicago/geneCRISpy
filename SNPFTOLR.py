import numpy as np
import pandas as pd
from sklearn.linear_model import LogisticRegression
from sklearn.metrics import classification_report

# Create a data set
data = {
    "SNP": ["A", "A", "G", "G"],
    "FTO": [1, 2, 1, 2],
    "Type 2 Diabetes": [0, 0, 1, 1]
}

# Create a Pandas DataFrame
df = pd.DataFrame(data)

# Create a logistic regression model
model = LogisticRegression()

# Train the model
model.fit(df[["SNP", "FTO"]], df["Type 2 Diabetes"])

# Make predictions
predictions = model.predict(df[["SNP", "FTO"]])

# Evaluate the model
print(classification_report(df["Type 2 Diabetes"], predictions))
