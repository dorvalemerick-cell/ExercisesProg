# Set and show a menu and its prices
# Demand what the user wants
# Add chosen items in a cart
# Calculate the total and show the items and the total to the user

menu = {"popcorn": 7.0,
        "soda": 2.0,
        "pizza": 5.0,
        "nachos": 6.0,
        "fries": 3.0,
        "candy": 3.5}

cart = []

total = 0

print("---------- MENU ----------")
for food, price in menu.items():
    print(f"{food:10}:${price:.2f}")

while True:
    order = input("Please order (q to quit): ").lower()
    if order == "q":
        break
    elif menu.get(order) is not None:
        cart.append(order)

for food in cart:
    total += menu.get(food)

print("---------- YOUR CART ----------")
for food in cart:
    print(food, end=" ")
print()
print(f"cost: ${total:.2f}")

