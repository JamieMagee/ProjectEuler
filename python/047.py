from math import sqrt


def factorise(n):
    factors = []
    while 0 == n % 2:
        factors.append(2)
        n /= 2
    i = 3
    lim = sqrt(n)
    while i <= lim:
        if n % i == 0:
            factors.append(i)
            n /= i
            lim = sqrt(n + i)
        else:
            i += 2
    if n != 1:
        factors.append(n)
    return factors

nums = []
for i in range(100000, 200000):
    if len(set(factorise(i))) == 4:
        nums.append(i)
print(next((nums[i] for i, n in enumerate(nums) if nums[i:i+4] == range(n, n+4))))