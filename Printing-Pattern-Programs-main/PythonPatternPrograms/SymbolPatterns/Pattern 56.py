n = 5
for x in range(n, 0, -1):
    for y in range(1, n + 1):
        if y > x:
            print("*", end=" ")
        else:
            print(x, end=" ")
    print()