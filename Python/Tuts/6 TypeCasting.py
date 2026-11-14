#Typecasting converts a value of int, str, float or even bool into an other type of value

name = "Em"
age = 16
student = True
gpa = 3.2

name = bool(name) # convert the str of name in a boolean
age1 = float(age) # convert the int of age into a floating point number
age2 = str(age) # converts the int of age into a string
age3 = bool(age) # converts the int of age into a boolean
gpa1 = int(gpa) # converts the float of gpa into a integer
gpa2 = str(gpa) # converts the float of gpa into a string
gpa3 = bool(gpa) # converts the float of gpa into a boolean

print(f"{name}, {age1}, {age2}, {age3}, {gpa1}, {gpa2}, {gpa3}")
print(type(name))
print(type(age1))
print(type(age2))
print(type(gpa1))
print(type(gpa2))