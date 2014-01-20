import math


def factorise(n):
    factors = []
    while 0 == n % 2:
        factors.append(2)
        n /= 2
    i = 3
    lim = math.sqrt(n)
    while i <= lim:
        if n % i == 0:
            factors.append(i)
            n /= i
            lim = math.sqrt(n + i)
        else:
            i += 2
    if n != 1:
        factors.append(n)
    return factors


print max(factorise(600851475143))
