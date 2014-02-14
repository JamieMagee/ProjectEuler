def primegen(n):
    sieve = [True] * n
    for i in range(3, int(n ** 0.5) + 1, 2):
        if sieve[i]:
            sieve[i * i::2 * i] = [False] * ((n - i * i - 1) / (2 * i) + 1)
    return [2] + [i for i in range(3, n, 2) if sieve[i]]


def perm(x, y):
    return sorted(list(str(x))) == sorted(list(str(y)))

primes = primegen(9999)
a = 1489
while True:
    b, c = a + 3330, a + 6660
    if a in primes and b in primes and c in primes and perm(a, b) and perm(b, c):
        break
    a += 2
print(str(a) + str(b) + str(c))