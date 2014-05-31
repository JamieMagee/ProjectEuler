from itertools import combinations
from operator import *


def pentgen(n):
    pent = set()
    for i in range(1, n):
        pent.add(i * (3 * i - 1) // 2)
    return pent


pent = pentgen(3000)
c = combinations(pent, 2)
for p in c:
    if add(*p) in pent and abs(sub(*p)) in pent:
        print(abs(sub(*p)))
