def primes(n):
    sieve = [True] * n
    for i in range(3, int(n ** 0.5) + 1, 2):
        if sieve[i]:
            sieve[i * i::2 * i] = [False] * ((n - i * i - 1) / (2 * i) + 1)
    return [2] + [i for i in range(3, n, 2) if sieve[i]]


def accum(n):
    total = 0
    for x in n:
        total += x
        yield total


p = primes(1000000)
pc = list(accum(p))
chain, longest = 0, 0
for i in range(chain, len(pc)):
    for j in range(i - (chain + 1), 0, -1):
        if (pc[i] - pc[j]) > 1000000:
            break
        if (pc[i] - pc[j]) in p:
            chain = i - j
            longest = pc[i] - pc[j]
print(longest)