ph = 5  # height
ps = ph - 1  # space
inc = 1

for x in range(0, ph):
    for y in range(ps, x, -1):
        print(" ", end="")
    for z in range(0, x + 1):
        print("* ", end="")

    for y in range(ph + ph - 2, inc - 1, -1):
        print(" ", end="")
    for z in range(0, x + 1):
        print("* ", end="")

    inc += 2
    print()