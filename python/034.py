from math import factorial


def sumfac(n):
    r = 0
    while n:
        r, n = r + factorial(n % 10), n // 10
    return r


def issumoffac(n):
    return n == sumfac(n)


ans = 0
for i in range(3, 50000):
    if issumoffac(i):
        ans += i
print(ans)