def cycle(n):
    length = 1
    remainder = 10 % n
    while remainder != 1:
        remainder = remainder * 10 % n
        length += 1
    return length


length = 0
for i in range(999, 2, -2):
    if i % 5:
        if cycle(i) > length:
            ans = i
            length = cycle(i)
print(ans)