# casting input into integer
max = 0
n = int(input("Enter total no. of entities : "))
print("Enter values : ")
numArr = [int(input()) for i in range(n)]
print("  BAR CHART  ")
for x in range(0, n):
    if (numArr[x] > max):
        max = numArr[x]
for x in range(0, n):
    print("[" + str(x + 1) + "]", end="")
    for y in range(0, numArr[x]):
        print("#", end=" ")
    print()
    print()