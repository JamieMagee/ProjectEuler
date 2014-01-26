from itertools import product


def primegen(n):
    sieve = [True] * n
    for i in xrange(3, int(n**0.5)+1, 2):
        if sieve[i]:
            sieve[i*i::2*i] = [False]*((n-i*i-1)/(2*i)+1)
    return [2] + [i for i in xrange(3, n, 2) if sieve[i]]

p = primegen(6000)
composites = set(n for n in range(2, 6000) if n not in p)
sq = set(2*(n**2) for n in range(50))
sums = set(sum(c) for c in product(p, sq))
print(min(n for n in composites if n not in sums and n % 2 != 0))