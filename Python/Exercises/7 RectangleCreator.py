
running = True
while running:
    rect_height = int(input("Height: "))
    rect_width = int(input("Width: "))
    rect_symbol = input("Symbol: ")

    def rect(height=rect_height, width=rect_width, symbol=rect_symbol):
        for collumns in range(height):
            for collumn in range(width):
                print(symbol, end=" ")
            print()

    rect()

    if not input("Would you like to exit? (y/n): ").lower() == "n":
        running = False
