# for loops exectute a block of code a fixed amount of times
#       You can itterate over a range, string, sequence, etc.

for x in range(1, 11): # Counts to 10 (second number is excluding)
    print(x)

for x in reversed(range(1, 11)): #Counts from 10 to 1
    print(x)

credit_card = "1234-5678-9011-1234"

for x in credit_card: #Basically stores credit_card into x to be usable inside the loop
    if x == "-": 
        continue
    else:
        print(x)

for x in range(2, 26 , 2): #the third number is the step of numbers to count
    if x == 22:
        continue #Continue just... continues without the specified condition
    else:
        print(x)
