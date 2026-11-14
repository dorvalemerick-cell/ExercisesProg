# Collections
#   Set: {} unordered and immutable. Can ADD/REMOVE. NO duplicates

fruits = {"apple", "coconut", "pineapple", "strawberry"}

print("apple" in fruits) # Same as in lists
fruits.remove("pineappel") # Removes the wanted value
fruits.add("blueberries") # Adds a value to the set
fruits.pop() #Removes the first value in the set