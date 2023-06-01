import random

def find_str(gene):
  """Finds all short tandem repeats (STRs) in a gene.

  Args:
    gene: A string representing the gene.

  Returns:
    A list of all STRs found in the gene.
  """

  # Create a Markov chain model of the gene.
  model = MarkovChain(gene)

  # Find all STRs in the gene.
  strs = []
  for i in range(len(gene) - 1):
    for j in range(1, len(gene) - i):
      str = gene[i:i + j]
      if model.predict(str) > 0.9:
        strs.append(str)

  return strs

class MarkovChain(object):
  """A Markov chain model.

  Attributes:
    transition_matrix: A matrix representing the transition probabilities of the Markov chain.
  """

  def __init__(self, gene):
    """Creates a Markov chain model for a gene.

    Args:
      gene: A string representing the gene.
    """

    self.transition_matrix = self._create_transition_matrix(gene)

  def _create_transition_matrix(self, gene):
    """Creates a transition matrix for a gene.

    Args:
      gene: A string representing the gene.

    Returns:
      A matrix representing the transition probabilities of the Markov chain.
    """

    transition_matrix = [[0 for i in range(len(gene))] for j in range(len(gene))]
    for i in range(len(gene)):
      for j in range(len(gene)):
        if gene[i] == gene[j]:
          transition_matrix[i][j] = 1
        else:
          transition_matrix[i][j] = 0

    return transition_matrix

  def predict(self, str):
    """Predicts the probability of a particular string occurring in the Markov chain.

    Args:
      str: A string representing the string to predict.

    Returns:
      The probability of the string occurring in the Markov chain.
    """

    probability = 1.0
    for i in range(len(str) - 1):
      probability *= self.transition_matrix[str[i]][str[i + 1]]

    return probability
