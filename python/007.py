import math


def prime(n):
    if n == 1:
        return False
    elif n < 4:
        return True
    elif n % 2 == 0:
        return False
    elif n < 9:
        return True
    elif n % 3 == 0:
        return False
    else:
        r = int(math.floor(math.sqrt(n)))
        f = 5
        while f <= r:
            if n % f == 0:
                return False
            if n % (f + 2) == 0:
                return False
            f += 6
    return True


candidate = 1
i = 1
while i < 10001:
    candidate += 2
    if prime(candidate):
        i += 1
print(candidate)
