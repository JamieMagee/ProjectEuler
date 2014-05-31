import math


def gcd(a, b):
    return gcd(b, a % b) if b else a


lim, max = 1000, 0
count = [0] * lim
for n in range(1, int(math.sqrt(lim)), 2):
    for m in range(2, int(math.sqrt(lim)), 2):
        if gcd(n, m) == 1:
            sum = 2 * m * n + m * m + n * n + abs(m * m - n * n)
            for s in range(sum, lim, sum):
                count[s] += 1
for i in range(1, lim):
    if count[i] > max:
        ans, max = i, count[i]
print(ans)