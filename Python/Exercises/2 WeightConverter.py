weight = float(input("What is your weight?: "))
unit = input("Kilograms or pounds? (K or L): ")

if unit == "K":
    weight = weight * 2.205
    unit = "lbs."
    print(f"You are {round(weight, 2)} {unit}")
elif unit == "L":
    weight = weight / 2.205
    unit = "kgs."
    print(f"You are {round(weight, 2)} {unit}")
else:
    print("Please write the desired unit.")


