import random

low = 1
high = 100

names = ("Emerick", "Olivier", "Oceane", "Mateo", "Henry")
cards = ["2", "3", "4", "5", "6", "7", "8", "9", "J", "Q", "K", "A"]

numbers = random.randint(low, high)     # Choses a random integer from an array with a defined start and end
floats = random.random()                # Choses a number in between 0 and 1
text = random.choice(names)             # Chooses a value from an array of option at random
random.shuffle(cards)                   # Shuffles an array of numbers or strings in a random order

print(numbers)
print(floats)
print(text)
print(cards)                            # Be careful to print the list