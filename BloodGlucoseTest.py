def blood_glucose_test(patient_id, test_type, timestamp, glucose_level):
    """
    Code a Blood test to measure the levels of glucose in the patient's blood.

    Args:
        patient_id: The ID of the patient.
        test_type: The type of test, which can be one of "fasting_glucose", "oral_glucose_tolerance", or "random_glucose".
        timestamp: The timestamp of the test.
        glucose_level: The glucose level in the patient's blood.

    Returns:
        A dictionary with the following keys:
            * `patient_id`: The ID of the patient.
            * `test_type`: The type of test.
            * `timestamp`: The timestamp of the test.
            * `glucose_level`: The glucose level in the patient's blood.
    """

    # Check the validity of the test type.
    if test_type not in ["fasting_glucose", "oral_glucose_tolerance", "random_glucose"]:
        raise ValueError("Invalid test type.")

    # Create the dictionary.
    result = {
        "patient_id": patient_id,
        "test_type": test_type,
        "timestamp": timestamp,
        "glucose_level": glucose_level,
    }

    return result
