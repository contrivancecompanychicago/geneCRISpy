class VaccinePipeline:

    def __init__(self):
        self.vaccines = []

    def create_vaccine(self, name, description, ingredients, side_effects):
        vaccine = Vaccine(name, description, ingredients, side_effects)
        self.vaccines.append(vaccine)

    def store_vaccines(self, filename):
        with open(filename, "w") as f:
            json.dump(self.vaccines, f, indent=4)

    def load_vaccines(self, filename):
        with open(filename, "r") as f:
            self.vaccines = json.load(f)

    def get_vaccine(self, name):
        for vaccine in self.vaccines:
            if vaccine.name == name:
                return vaccine

    def get_all_vaccines(self):
        return self.vaccines


class Vaccine:

    def __init__(self, name, description, ingredients, side_effects):
        self.name = name
        self.description = description
        self.ingredients = ingredients
        self.side_effects = side_effects
