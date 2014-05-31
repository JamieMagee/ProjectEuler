ans = 0
for i in range(1, 101):
    d, n, v = 1, i, 1
    while n > i / 2:
        v = v * n / d
        if v > 1000000:
            ans += (1 + i) - (d << 1)
            break
        n -= 1
        d += 1
print(ans)