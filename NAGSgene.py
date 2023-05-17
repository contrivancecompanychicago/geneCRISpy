# Original code
def main():
  # Get the input data
  data = pd.read_csv("NAGS_gene_data.csv")

  # Calculate the bond lengths and angles
  bond_lengths = np.array(data["bond_lengths"])
  bond_angles = np.array(data["bond_angles"])

  # Plot the bond lengths and angles
  plt.scatter(bond_lengths, bond_angles)
  plt.xlabel("Bond length (Angstroms)")
  plt.ylabel("Bond angle (degrees)")
  plt.show()

# Refactored code
def calculate_bond_lengths_and_angles(data):
  bond_lengths = np.array(data["bond_lengths"])
  bond_angles = np.array(data["bond_angles"])
  return bond_lengths, bond_angles

def plot_bond_lengths_and_angles(bond_lengths, bond_angles):
  plt.scatter(bond_lengths, bond_angles)
  plt.xlabel("Bond length (Angstroms)")
  plt.ylabel("Bond angle (degrees)")
  plt.show()

def main():
  # Get the input data
  data = pd.read_csv("NAGS_gene_data.csv")

  # Calculate the bond lengths and angles
  bond_lengths, bond_angles = calculate_bond_lengths_and_angles(data)

  # Plot the bond lengths and angles
  plot_bond_lengths_and_angles(bond_lengths, bond_angles)

if __name__ == "__main__":
  main()
