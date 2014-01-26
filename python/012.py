def primes(n):
    sieve = [True] * n
    for i in range(3, int(n**0.5)+1, 2):
        if sieve[i]:
            sieve[i*i::2*i] = [False]*((n-i*i-1)/(2*i)+1)
    return [2] + [i for i in range(3, n, 2) if sieve[i]]

prime = primes(1000)
factors = 0
n = 3
divn = 2

while factors < 500:
    n += 1
    n1 = n
    if n1 % 2 == 0:
        n1 /= 2
    divn1 = 1
    for i in range(0, len(prime)):
        if prime[i]**2 > n1:
            divn1 *= 2
            break
        exp = 1
        while n1 % prime[i] == 0:
            exp += 1
            n1 /= prime[i]
        if exp:
            divn1 *= exp
        if n1 is 1:
            break
    factors = divn * divn1
    divn = divn1

print((n*(n-1)/2))
