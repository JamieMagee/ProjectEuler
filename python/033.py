from itertools import product
from fractions import Fraction


def iscurious(n, d):
    f = Fraction(n, d)
    if f >= 1:
        return False
    ndigits = [int(digit) for digit in str(n)]
    ddigits = [int(digit) for digit in str(d)]
    if ndigits[1] == ddigits[0] and ddigits[1] != 0 and Fraction(ndigits[0], ddigits[1]) == f:
        return True
    return False

frac = product(range(10, 100), range(10, 100))
print reduce(lambda a, b: a * b, (Fraction(*f) for f in frac if iscurious(*f))).denominator
