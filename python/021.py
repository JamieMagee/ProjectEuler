def sod(n):
    sum, p = 1, 2
    while p ** 2 <= n and n > 1:
        if not n % p:
            j = p ** 2
            n /= p
            while not n % p:
                j *= p
                n /= p
            sum *= j - 1
            sum /= p - 1
        p = 3 if p == 2 else p + 2
    if n > 1:
        sum *= n + 1
    return sum


def sopd(n):
    return sod(n) - n


ans = 0
for a in range(2, 10000):
    b = sopd(a)
    if b > a:
        if sopd(b) == a:
            ans += a + b
print(ans)