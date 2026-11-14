import random

low = 1
high = 100


number = random.randint(low, high)

guesses = 0

while True:
    guess = int(input(f"Guess a  number in between {low} - {high}: "))
    if guess < number:
        print(f"{guess} is too low")
        guesses += 1
    elif guess > number:
        print(f"{guess} is too high")
        guesses += 1
    else:
        print(f"{guess} is correct!")
        break
print(f"Number of guesses: {guesses} times")
