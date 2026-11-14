# Dictionaries (mandatory)
# User input (mandatory)
# For loops, While loops or both (mandatory)
# Lists (not mandatory)
# Indexing (not mandatory)
# 2D collection (nto mandatory)

import time

foods = {}

print("----------------")
print("  FOOD CREATOR  ")
print("----------------")

while True:
    food_add = str(input("Please select a food that to the machine: "))
    if food_add.isalpha():
        print(f"Addding {food_add} to list")     
        for x in range(1, 4):
            print("*", end=" ")
            time.sleep(0.5)
        print()
    else:
        print("You need to enter a food")
        
    ingredient_add = str(input("Please select a key ingredient to the machine: "))
    if ingredient_add.isalpha():
        print(f"Adding {ingredient_add}")
        for x in range(1, 4):
            print("*", end=" ")
            time.sleep(0.5)
        print()
    else:
        print("You need to add an ingredient")
    foods.update({f"{food_add}": f"{ingredient_add}"})
    result = input("'r' to see results, 'c' to continue: ").lower()
    if result == "r":
        print("moving to next part")
        break
    else:
        print("continuing")

print("-----------------")
print("     RESUTLS     ")
print("-----------------")

for food, ingredients in foods.items():
    print(f"You have created {food} with {ingredients}")



