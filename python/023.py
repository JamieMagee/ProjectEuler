from itertools import *
from functools import reduce

def primegen(n):
    sieve = [True] * n
    for i in xrange(3, int(n**0.5)+1, 2):
        if sieve[i]:
            sieve[i*i::2*i] = [False]*((n-i*i-1)/(2*i)+1)
    return [2] + [i for i in xrange(3, n, 2) if sieve[i]]

def factorize(n):
    factors = []
    for p in primes:
        if p * p > n:
            break
        i = 0
        while n % p == 0:
            n //= p
            i += 1
        if i > 0:
            factors.append((p, i))
    if n > 1:
        factors.append((n, 1))

    return factors


def divisors(n):
    factors = list(factorize(n))
    nfactors = len(factors)
    f = [0] * nfactors
    while True:
        yield reduce(lambda x, y: x*y, [factors[x][0]**f[x] for x in range(nfactors)], 1)
        i = 0
        while True:
            f[i] += 1
            if f[i] <= factors[i][1]:
                break
            f[i] = 0
            i += 1
            if i >= nfactors:
                return


def properdivisors(n):
    return list(divisors(n))[:-1]

primes = primegen(25)
abundant = set(number for number in range(12, 20162) if sum(properdivisors(number)) > number)
sums = sorted(set(sum(c) for c in combinations_with_replacement(abundant, 2)))
print(sum(number for number in range(1, 20162) if number not in sums))