a = b = c = 1
s = 0
while c < 4e6:
    c = a + b
    if c % 2 == 0:
        s += c
    a = b
    b = c

print(s)