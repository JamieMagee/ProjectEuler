def circular_prime(x):
    k = x
    d = 0
    while x:
        x /= 10
        d += 1
    for i in range(0, d):
        if not p[k]:
            return 0
        k = (k % 10) * p10[d - 1] + k / 10
    return p[k]


p = [True] * 1000000
p10 = [1, 10, 100, 1000, 10000, 100000]
ans = 1
for i in range(4, 1000000, 2):
    p[i] = False
for i in range(3, 1000, 2):
    if p[i]:
        for j in range(i * 2, 1000000, i):
            p[j] = False
for i in range(3, 1000000, 2):
    ans += circular_prime(i)
print(ans)

