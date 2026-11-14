questions = (("How many fingers do humans have?: "),
             ("How many toes to humans have?: "),
             ("How many calories does a Cruch breverage contain?: "))

options = (("A. 11", "B. 12", "C. 10", "D. 14"),
           ("A. 10", "B. 80", "C. 14", "D. 8"),
           ("A. 150cal", "B. 160cal", "C. 170cal", "D. 180cal"))

answers = ["C", "A", "B"]
guesses = []
option_num = 0
score = 0

for question in questions:
    print("--------------------")
    print(question)

    for option in options[option_num]:
        print(option)
    
    guess = input("Enter your answer (A, B, C, D): ").upper()
    guesses.append(guess)
    if guess == answers[option_num]:
        print(f"{guess} is correct!")
        score += 1
    else:
        print(f"{guess} is incorrect!")
    option_num += 1

print("---------------------")
print("       RESUTLT       ")
print("---------------------")

print("Answers: ", end=" ")
for answer in answers:
    print(answer, end=" ")
print()

print("Guesses: ", end="")
for guess in guesses:
    print(guess, end=" ")
print()

score = int((score / len(questions)) * 100)
print(f"Your score is: {score}%")
