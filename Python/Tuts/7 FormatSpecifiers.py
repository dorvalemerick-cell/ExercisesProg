price1 = 4501.6041
price2 = 6781.8965
price3 = 3956.254

print(f"Price1 is ${price1:+10,.2f}")
print(f"Price2 is ${price2:-20.5f}")
print(f"Price3 is ${price3:.10f}")

# {value:.any_number(f)} to round the value assigned to the f string to any number
# {value:,} to put a coma to each thousandth
# {value:any_number} to indext the value assigned to the f string to any number
# {value:+} to simply put a plus sign behind the assigned value
