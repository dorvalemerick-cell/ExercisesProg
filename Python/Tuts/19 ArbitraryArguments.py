# *args     = allows you to pass multiple non-key arguments, acts as a tuple
# **kwargs  = allows you to pass multiple keyword arguments, acts as a dictionary


def name(*args):
    for arg in args:
        print(arg, end=" ")
#name("Emerick", "Dorval")


def shipping(*args, **kwargs):
    for arg in args:
        print(arg, end=" ")
    print()

    print(f"{kwargs.get("address")} {kwargs.get("str")} {kwargs.get("city")}")
    print(f"{kwargs.get("province")} {kwargs.get("zip")}")

shipping("Mr.", "Spongebob", "Squarepants",
         str="213 Fake St.",
         address="#100",
         city="Montreal",
         province="Quebec",
         zip="123456")