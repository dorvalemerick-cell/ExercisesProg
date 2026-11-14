
questions = (("What is Mercury known to be closer to"),
             ("At what temperature does water boil"),
             ("What is the annoying bird"))

tips =      (("It is very very hot"),
            ("It has three numbers, two are identical"),
            ("It poops mainly on cars"))

options =   (("A. Venus", "B. Earth", "C. The Sun", "D. The Moon"),
            ("A. 55°C", "B. 95°C", "C. 0°C", "D. 100°C"),
            ("A. Pigeons", "B. Cardinals", "C. Seagull", "D. Blue Jay"))

answers  = (("C"), ("D"), ("A"))

good_answers = []
incorrect_answers = []

question_num = 0

score = 0

for question in questions:
    print("---------------")
    print(question)
    tip = input("Do you want a tip? (y/n): ").lower()
    if tip == "n":
        print("Have it your way")
    else:
        print(tips[question_num])

    for option in options[question_num]:
        print(option)

    print()

    answer = input("Enter your answer: ")
    if answer.upper() == answers[question_num]:
        print("CORRECT")
        question_num = question_num + 1
        score = score + 1
        good_answers.append(answer)
    else:
        incorrect_answers.append(answer)
        question_num = question_num + 1
        print("INCORRECT")

print("Incorrect answers: ")
for incorrect in incorrect_answers:
    print(incorrect, end=" ")
    
print()

print("Corect Answers: ")
for good in good_answers:
    print(good, end=" ")

print()

print(f"Your Score: {score}/{len(questions)}")



    


