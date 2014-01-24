def primegen(n):
    sieve = [True] * n
    for i in xrange(3, int(n ** 0.5) + 1, 2):
        if sieve[i]:
            sieve[i * i::2 * i] = [False] * ((n - i * i - 1) / (2 * i) + 1)
    return [2] + [i for i in xrange(3, n, 2) if sieve[i]]


def trunc(n):
    return set(int(str(n)[i:]) for i in range(1, len(str(n)))).union(
        set(int(str(n)[:i]) for i in range(1, len(str(n))))).union([i])


p = set(primegen(750000))
count, ans = 0, 0
for i in p:
    if i > 7:
        if trunc(i) <= p:
            count += 1
            ans += i
            if count == 11:
                break
        i += 1

print(ans)
