longest = 0
collatz = [0] * 1000000
collatz[1] = 1

for i in range(2, 1000000):
    num = i
    len = 0
    while num is not 1:
        num = 3 * num + 1 if num % 2 else num // 2
        len += 1
        if num < 1000000 and collatz[num]:
            len += collatz[num]
            break
    collatz[i] = len
    if len > longest:
        ans = i
        longest = len

print(ans)
