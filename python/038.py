pand = {'1', '2', '3', '4', '5', '6', '7', '8', '9'}
largest = 0
for i in range(1, 10000):
    j = 1
    num = []
    while sum(len(s) for s in num) < 9:
        num.append(str(i*j))
        j += 1
    if sum(len(s) for s in num) == 9 and set(sum(([list(s) for s in num]), [])) == pand and ''.join(num) > largest:
        largest = ''.join(num)

print(largest)
