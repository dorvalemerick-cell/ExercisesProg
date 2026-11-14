# While loops execute a block of code WHILE a condition is true

even_num = int(input("Type an even number: "))

while not even_num % 2 == 0:
    print("That number isn't even...")
    even_num = int(input("Type and even number: "))

print("Great! That number is even :)")
