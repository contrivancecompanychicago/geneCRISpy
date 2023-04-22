import numpy as np
import matplotlib.pyplot as plt

# Read the data
data = np.loadtxt("data.csv")

# Preprocess the data
data = data[data[:, 0] == "Fasting Glucose"]

# Analyze the data
mean = np.mean(data[:, 1])
std = np.std(data[:, 1])

# Visualize the results
plt.hist(data[:, 1])
plt.axvline(mean, color="red")
plt.axvline(mean + std, color="green")
plt.axvline(mean - std, color="blue")
plt.show()

# Save the results
np.savetxt("results.csv", data)
