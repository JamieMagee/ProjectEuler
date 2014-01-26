import math

primes = [2, 3, 5, 7, 11, 13, 17, 19, 23]
a = [1] * 10
i = 0
n = 1
check = True

while primes[i] <= 20:
    if check:
        if primes[i] <= math.sqrt(20):
            a[i] = math.floor(math.log10(20)/math.log10(primes[i]))
        else:
            check = False
    n *= math.pow(primes[i], a[i])
    i += 1

print(int(n))