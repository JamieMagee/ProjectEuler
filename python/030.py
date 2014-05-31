def sumpowers(n):
    r = 0
    while n:
        r, n = r + (n % 10) ** 5, n / 10
    return r


def fifthpower(n):
    return n == sumpowers(n)


ans = 0
for i in range(2, 200000):
    if fifthpower(i):
        ans += i
print(ans)