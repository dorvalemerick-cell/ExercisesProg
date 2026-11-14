# Collections
#   Lists: [] ordered and changeable. Duplicates OK
#   Tupple: () ordered and unchangeable. Duplicates OK. FASTER


fruits = ["apple", "banana", "coconut", "watermelon"]

fruits[0] = "pineaple" # Changes the value in the given index
fruits.append("pineaple") # Adds a new value at the end of the list
fruits.remove("apple") # pretty self explanatory
fruits.insert(2, "strawberry") # Inserts a value at the given index
fruits.sort() # Sorts the values in an alphabetical order
fruits.reverse() # Reverses the order of the values
print(fruits.index("banana")) # Returns the position of the wanted value in the list
print(fruits.count("coconut")) # Counts how many of the given value is in the list
print("banana" in fruits) # Checks if the given value is inside the given list
print(fruits)