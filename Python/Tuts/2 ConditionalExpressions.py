# A Conditionnal Expression is a one line shortcut to conditional statements (if, elif, else)

num = 5
num2 = 6
a = 1
b = 2
temp = -10
access = "admin"

print("Positive" if num > 0 else "Negative")
print("EVEN" if num2 % 2 == 0 else "ODD")
maxNum = a if a > b else b
minNum = a if a < b else b
weather = "HOT" if temp >= 20 else "CHILLY"
login = "FULL ACCESS" if access == "admin" else "LIMITED ACCESS"

print(maxNum)
print(minNum)
print(weather)
print(login)
