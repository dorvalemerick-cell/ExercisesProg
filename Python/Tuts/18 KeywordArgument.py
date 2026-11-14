# Instead of defining the values inside the function, keyword arguments are used outside of the function

def get_phone(country, area, first, last):
    return f"{country}-{area}-{first}-{last}"

phone_num = get_phone(area=234, country=1, first=567, last=8901)
print(phone_num)