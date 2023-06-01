import random

def generate_fto_gene():
  """Generates a linear FTO gene."""
  gene = []
  for i in range(1000):
    gene.append(random.choice("ACGT"))
  return gene

def find_strs(gene):
  """Finds all STRs in the given gene."""
  strs = []
  for i in range(len(gene) - 1):
    str_length = 1
    while i + str_length < len(gene) and gene[i] == gene[i + str_length]:
      str_length += 1
    strs.append(gene[i:i + str_length])
  return strs

def main():
  gene = generate_fto_gene()
  strs = find_strs(gene)
  print(strs)

if __name__ == "__main__":
  main()
