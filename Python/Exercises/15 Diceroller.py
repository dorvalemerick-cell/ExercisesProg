import random


# ● ┌ ─ ┐ │ └ ┘

dice_art = {
    1: (("┌─────────┐"), 
        ("│         │"), 
        ("│    ●    │"), 
        ("│         │"), 
        ("└─────────┘")),
    2: (("┌─────────┐"), 
        ("│ ●       │"), 
        ("│         │"), 
        ("│       ● │"), 
        ("└─────────┘")),
    3: (("┌─────────┐"), 
        ("│ ●       │"), 
        ("│    ●    │"), 
        ("│       ● │"), 
        ("└─────────┘")),
    4: (("┌─────────┐"), 
        ("│ ●     ● │"), 
        ("│         │"), 
        ("│ ●     ● │"), 
        ("└─────────┘")),
    5: (("┌─────────┐"), 
        ("│ ●     ● │"), 
        ("│    ●    │"), 
        ("│ ●     ● │"), 
        ("└─────────┘")),
    6: (("┌─────────┐"), 
        ("│ ●     ● │"), 
        ("│ ●     ● │"), 
        ("│ ●     ● │"), 
        ("└─────────┘"))
}

dice = []
total = 0

number_of_dice = int(input("How many dice?: "))

for die in range(number_of_dice):                   #For each itteration of the number we inputed above
    dice.append(random.randint(1, 6))               #Randomize a number in between 1 and six and add it to the list: dice

for line in range(5):                               #For each line(5 in total)
    for die in dice:                                #For each int in dice[]
        print(dice_art.get(die)[line], end="")      #Get the int in dice[], transform it into key, display its value
    print()

for die in dice:
    total += die

print(f"Total: {total}")

