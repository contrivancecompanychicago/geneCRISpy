#!/usr/bin/env python

# This is an automatically generated script to run your query
# to use it you will require the intermine python client.
# To install the client, run the following command from a terminal:
#
#     sudo easy_install intermine
#
# For further documentation you can visit:
#     http://intermine.readthedocs.org/en/latest/web-services/

# The line below will be needed if you are running this script with python 2.
# Python 3 will ignore it.
from __future__ import print_function

# The following two lines will be needed in every python script:
from intermine.webservice import Service
service = Service("https://www.humanmine.org/humanmine/service")

# Get a new query on the class (table) you will be querying:
query = service.new_query("Gene")

# The view specifies the output columns
query.add_view(
    "primaryIdentifier", "symbol", "diseases.hpoAnnotations.hpoTerm.name",
    "diseases.hpoAnnotations.hpoTerm.identifier",
    "diseases.hpoAnnotations.evidences.publications.pubMedId"
)

# Uncomment and edit the line below (the default) to select a custom sort order:
# query.add_sort_order("Gene.primaryIdentifier", "ASC")

# You can edit the constraint values below
query.add_constraint("Gene", "LOOKUP", "FTO", code="A")

# Uncomment and edit the code below to specify your own custom logic:
# query.set_logic("A")

# Outer Joins
# (display properties of these relations if they exist,
# but also show objects without these relationships)
query.outerjoin("diseases.hpoAnnotations.evidences")

for row in query.rows():
    print(row["primaryIdentifier"], row["symbol"], row["diseases.hpoAnnotations.hpoTerm.name"], \
        row["diseases.hpoAnnotations.hpoTerm.identifier"], \
        row["diseases.hpoAnnotations.evidences.publications.pubMedId"])
