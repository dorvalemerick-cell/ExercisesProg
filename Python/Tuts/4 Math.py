import math

print("Hypothenuze finder")
aSide = float(input("Enter length of side A: "))
bSide = float(input("Enter length of side B: "))
hypothenuze = math.sqrt(pow(aSide, 2) + pow(bSide, 2))
print(f"The hypothenuze of your triangle is of {round(hypothenuze, 2)}cm")