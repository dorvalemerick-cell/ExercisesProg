
capitals = {"USA": "Washington D.C.",
            "India": "New delhi",
            "Russia": "Moscow",
            "China": "Beijing"}

print(capitals.get("USA"))                  # Gets the value of a specified key
capitals.update({"Germany": "Berlin"})      # Adds a new key value pair into the dictionary
capitals.pop("China")                       # Deletes a key value pair
capitals.popitem()                          # Deletes the latest key value pair
capitals.clear()                            # Clears the dictionary

keys = capitals.keys()                      # Takes every key from the 'capitals' dictionary
for key in capitals.keys():                 # List every key
    print(key)

values = capitals.values()                  # Takes every value from the 'capitals' dictionary
for value in capitals.values():             # Lists every value from the 'capitals' dictionary
    print(value)


print(capitals.items())                     # Lists the dictionary in a 2D collection like environement

for key, values in capitals.items():        # Separate each key value pair from the dictionary
    print(f"{key}: {values}")