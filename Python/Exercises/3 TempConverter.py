print("Temperature Converter")
unit = input("Is this temperature in Celius or Faranheit? (C or F): ")
temp = float(input("What is  the temperature?: "))

if unit == "C":
    temp = round((9 * temp) / 5 + 32, 1)
    print(f"The temperature in faranheit is {temp}°F")
elif unit == "F":
    temp = round((temp -32) * 5 / 9, 1)
    print(f"It is {temp}°C")
else:
    print(f"{unit} is not recognized as a temperature unit")
