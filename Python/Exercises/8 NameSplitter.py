import time

names = [] # Empty list
chars = [] # Empty list

username = input("Enter username: ")

print(f"Welcome {username}")

while True:
    name = input("Enter a name: ")                 # Ask for input, store it in name
    split = input("Chose a character to remove: ") # Ask for input, store it in split
    if not split in name:
        print(f"{split} is not in the name")
    elif len(split) > 1:                           # Split can't be greater than one
        print("Only one character is accepted")
    else:
        index = name.index(split)                  # Takes position of split inside name and stores in index
        symbol = '*'
        print(f"Removing {split}")
        for x in range(0, 5):                      # Countdown to 3
            print(symbol, end=" ")
            time.sleep(1)

        chars.append(split)                        # Adds the contents of split inside the list: chars

        first_half = name[:index]                  # Takes the side left of the split value, store it in first_half
        second_half = name[index + 1:]             # Takes the side right of he split value, store it in second_half

        full_name = f'{first_half} {second_half}'  # Mash the two halves together, store it in full_name
        names.append(full_name)                    # Add full_name to list: names

        print()

        print(f"The split name is now {full_name}")

        game_loop = input("To see results 'R'. 'r' to restart. Any key to continue: ")
        if game_loop == "R":                      # Check if 'R' is pressed
            break                                 # Break the loop
        elif game_loop == 'r':
            names= []
            continue
        else:
            continue
print("--------------------------")
print("Names obtained")
for name in names:  
    print(name, end="  ")                        # Lists the full_names created
 
print()

print("Characters removed")                      # Lists all of the characters removed
for char in chars:
    print(char, end=" ")