# Logical operators are used on conditional statements (if's)

#               and: checks if two or more statements are true
#               or: checks if at least one of the statements is true
#               not: checks if a statement isn't true (Acts like an else/elif)

temp1 = float(input("Enter the temperature: "))

if temp1 > 0 and temp1 < 30:
    print(f"It is {temp1} outside? That's pretty comfy")
else:
    print(f"It's {temp1} outside? That's pretty bad, no?")



temp2 = float(input("Enter the temperature(2): "))

if temp2 <=0 or temp2 >= 30:
    print(f"it's {temp2} outside? Oof... poor you...")
    sunny = False
else:
    print(f"{temp2}, huh?... pretty nice")
    sunny = True



sunny = True

if not sunny:
    print("It isn't sunny outside...")
else:
    print("it is sunny outside :)")