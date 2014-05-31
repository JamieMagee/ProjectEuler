import math


def gcd(a, b):
    return gcd(b, a % b) if b else a


s = 1000 // 2
limit = int(math.ceil(math.sqrt(s)) - 1)
i = 2
for i in range(2, limit):
    if s % i == 0:
        si = s // i
        while si % 2 == 0:
            si //= 2
        k = i + 2 if i % 2 else i + 1
        while k < 2 * i and k <= si:
            if si % k is 0 and gcd(k, i) is 1:
                d = s // (k * i)
                n = k - i
                a = d * (i * i - n * n)
                b = 2 * d * i * n
                c = d * (i * i + n * n)
            k += 2
print((a * b * c))