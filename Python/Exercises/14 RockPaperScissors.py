import random

options = ("rock", "paper", "scissors")

good_guesses = []
bad_guesses = []

score = 0

running = True
while running:
    computer = random.choice(options)
    player = None

    while player not in options:
        player = input("Choose rock paper or scissors: ").lower()

    if player == computer:
        print("It's a tie")
    elif player == "rock" and computer == "scissors":
        score += 1
        print("You Win!")
        good_guesses.append(player)
    elif player == "paper" and computer == "rock":
        score += 1
        print("You Win!")
        good_guesses.append(player)
    elif player == "scissors" and computer == "paper":
        score += 1
        print("You Win!")
        good_guesses.append(player)
    else:
        print("You Loose!")
        bad_guesses.append(player)
        score -= 1

    if input("Do you want to restart? (y/n): ").lower() == "n":
        running = False

print("---------------")
print("--- RESULTS ---")
print("---------------")

print(f"Rounds Won: {len(good_guesses):5}")
print(f"Rounds Lost: {len(bad_guesses):5}")
print(f"Score: {score:5}")
