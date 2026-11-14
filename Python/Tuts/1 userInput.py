# User input, like it's name says, lets the user input something and stores it inside a variable (or not)

food = input("What did you buy?: ")
price = float(input("How expensive is it?: "))
quantity = int(input("How much did you buy?: "))

total = price * quantity

print(f"You bought {food} {quantity}  times")
print(f"Your total is of {round(total, 2)} dollars")