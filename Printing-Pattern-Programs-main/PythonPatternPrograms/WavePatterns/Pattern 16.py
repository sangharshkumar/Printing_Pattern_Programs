wH = 5  # 1
wL = 4  # 2
insp = 1  # 3
ousp = 2  # 4

for x in range(1, wH + 1):
    for y in range(1, wL + 1):
        for z in range(1, ousp + 1):
            print(" ", end="")
        print("0", end="")  # any symbol
        for z in range(1, insp + 1):
            print(" ", end="")
        print("0", end="")  # any symbol
        for z in range(1, ousp + 1):
            print(" ", end="")
        print(" ", end="")

    ousp = (x + 1 != wH)  # 5

    if (x + 1 != wH):  # 6
        insp = 3
    else:
        insp = 5
    print()

    """
1) wH - change value to increase/decrease the height of the wave
2) wL - change value to increase/decrease the length of the wave
3) inner space
4) outer space
5) set value of ousp to 1 if x+1 is not equal to wave height (wH) or 0 otherwise
6) set value of insp to 3 if x+1 is not equal to wave height (wH) or 5 otherwise
    """