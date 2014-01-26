def primegen(n):
    sieve = [True] * n
    for i in range(3, int(n**0.5)+1, 2):
        if sieve[i]:
            sieve[i*i::2*i] = [False]*((n-i*i-1)/(2*i)+1)
    return [2] + [i for i in range(3, n, 2) if sieve[i]]


def f(a, b, n):
    return n**2 + (a*n) + b


def sequence_of_primes(a, b):
    n = 0
    t = True
    while t:
        t = f(a, b, n) in p
        n += 1
    return n-1


p = primegen(1000)
maximum = 0
for i in p:
    for j in p:
        l = sequence_of_primes(i, j)
        if l > maximum:
            maximum = l
            nums = (i, j)
        l = sequence_of_primes(-i, j)
        if l > maximum:
            maximum = l
            nums = (-i, j)
print((nums[0]*nums[1]))