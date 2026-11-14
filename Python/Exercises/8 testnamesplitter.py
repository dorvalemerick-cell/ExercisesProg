def split_name(word, letter):
    index = name.index(letter)
    first_half = name[:index]
    last_half = name[index + 1:]
    print(f"{first_half}{last_half}")

    name = input("Enter Name: ")
    split = input("Enter letter to remove: ")
    split_name(word=name, letter=split)
