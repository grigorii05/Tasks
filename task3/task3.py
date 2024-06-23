import json
import  sys

def update_report(tests, values):
    for test in tests:
        test_id = test["id"]
        if "value" in test:
            test["value"] = get_value(test_id, values)
        if "values" in test:
            update_report(test["values"], values)
    return tests


def get_value(test_id, values):
    for item in values["values"]:
        if item["id"] == test_id:
            return item["value"]
    return ""


def main():

    if len(sys.argv) != 4:
        raise ValueError('Please provide correct arguments')

    with open(sys.argv[1], "r") as f:
        values_data = json.load(f)
    with open(sys.argv[2], "r") as f:
        tests_data = json.load(f)

    report_data = tests_data
    data = update_report(tests_data["tests"], values_data)
    report_data["tests"] = data

    with open(sys.argv[3], "w") as f:
        json.dump(report_data, f, indent=4)

if __name__ == "__main__":
    main()