def isprime(n):
    if n == 2 or n == 3:
        return True
    if n < 2 or n % 2 == 0:
        return False
    if n < 9:
        return True
    if n % 3 == 0:
        return False
    r = int(n ** 0.5)
    f = 5
    while f <= r:
        if n % f == 0:
            return False
        if n % (f + 2) == 0:
            return False
        f += 6
    return True


def get5pattern():
    return [[1, 0, 0, 0, 1],
            [0, 1, 0, 0, 1],
            [0, 0, 1, 0, 1],
            [0, 0, 0, 1, 1]]


def get6pattern():
    return [[1, 1, 0, 0, 0, 1],
            [1, 0, 1, 0, 0, 1],
            [1, 0, 0, 1, 0, 1],
            [1, 0, 0, 0, 1, 1],
            [0, 1, 1, 0, 0, 1],
            [0, 1, 0, 1, 0, 1],
            [0, 1, 0, 0, 1, 1],
            [0, 0, 1, 1, 0, 1],
            [0, 0, 1, 0, 1, 1],
            [0, 0, 0, 1, 1, 1]]


def generatenumbers(pattern, numdigits):
    numbers = []
    for i in range(10):
        if pattern[0] == 0 and i == 0:
            continue
        nIdx, num = 0, []
        for p in pattern:
            if p == 1:
                num.append(numdigits[nIdx])
                nIdx += 1
            else:
                num.append(i)
        numbers.append(int(''.join(map(str, num))))
    return numbers


for num in range(11, 1000, 2):
    if num % 5 == 0:
        continue
    numDigits = [int(i) for i in str(num)]
    for pattern in get5pattern() if num < 100 else get6pattern():
        numbers = generatenumbers(pattern, numDigits)
        size = len(numbers)
        for number in numbers:
            if not isprime(number):
                size -= 1
                if size < 8:
                    break
        if size == 8:
            print(numbers[0])