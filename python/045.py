from math import sqrt

n, k, h = 1, 1.1, 0
while k != int(k) or h < 40756:
    n += 1
    h = n * (2 * n - 1)
    k = (1 + sqrt(1 + 24 * h)) / 6
print(h)