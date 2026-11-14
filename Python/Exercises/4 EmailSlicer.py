email = input("Enter your email: ")

index = email.index("@") # We find the position of the wanted character (in this case it's '@')

username = email[:index] # We store all values from pos 0 all the way to the '@' (basically this is: email[:'pos of index var'] )
domain = email[index + 1:]

print(f"Your username is {username} and your domain is {domain}")
