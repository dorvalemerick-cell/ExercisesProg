# Default arguments are used in functions to set the value of an argument without needing to do so out of the function

import time

def count(end, start=0):
    for x in range(start, end+1):
        print(x)
        time.sleep(1)
    print("DONE!")

end = int(input("Enter how much time you would like to wait: "))

count(end)