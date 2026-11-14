#nested loops basically loop other loops. The type of loops doesn't matter

#for x in range(3):
#    for y in range(1, 10):
#        print(y, end="")
#    print()


rows = int(input("Enter the number of rows: "))         #Stores the input (an integer) into the variable rows
collumns = int(input("Enter the number of collumns: ")) #Stores the input (an integer) into the variable collumns
symbol = input("Enter the symbol: ")                    #Stores the input (a string) into the variable symbol

for x in range(rows):         #Executes the block of codes the number of times inputed in the variable rows
    for y in range(collumns): #Execute it's own little block of code the number of times inputed in the var collumns
        print(symbol, end="") #Print the string inputed in the symbol variable
    print()                   #Each print statement, wether an argument in it or not, has an end line (/n) statement at
                              #the end of it which is the same as pressing enter after typing something or not.
                              #In this case, this acts like empty rows that get filled by the symbol we inputed earlier
