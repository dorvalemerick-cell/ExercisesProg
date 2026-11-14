foods = []
prices = []
total = 0

while True:
    food = input("Enter a food (q to quit): ")
    if food.lower() == "q":
        break
    else:
        price = int(input("Enter the price: "))
        foods.append(food)
        prices.append(price)
print("-----YOUR CART-----")

for food in foods:
    print(food)

for price in prices:
    total += price

print(f"Your price is ${total}")