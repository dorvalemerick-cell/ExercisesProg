# Dictionaries
# Random
# Lists
# User input
# Loops
# Indexing (not mandatory)

import random

emojis = []

faces = {
    "laugh": ["🤣", "😅", "😆", "😂", "😄", "😀"],
    "smile": ["😁", "😀", "😃", "😄", "🙂", "😊"],
    "cry"  : ["😢", "😩", "🥲", "🥹", "😩", "😭"],
    "angry": ["😡", "😤", "😒", "🤬", "👿" ,"😠"]
}

print("┌──────────────────────────────────────────────────────────────────────────┐")
print("|you have 5 emojis per type, choose how much you want to show and what type|")
print("└──────────────────────────────────────────────────────────────────────────┘")
while True:
    choose_emoji = input("Choose your emoji: ").lower()

    while not faces.get(choose_emoji):
        print(f"{choose_emoji} not recognized: please choose in between these options: ")
        for key, values in faces.items():
            print(f"{key}")
        choose_emoji = input("Choose your emoji: ").lower()
    random.shuffle(faces.get(choose_emoji))

    how_many_emoji = int(input("How many emojis do you want?: "))
    while len(faces.get(choose_emoji)) > 5:
        print("That is too much!")
        how_many_emoji = int(input("How many emojis do you want?: "))
   
    random_emoji = faces.get(choose_emoji)[:how_many_emoji]
    emojis.append(random_emoji)
    for emoji in emojis:
        for x in emoji:
            print(x, end=" ")
    print()
    emojis.clear()