from math import sqrt, floor


def istri(n):
    return floor(sqrt(8 * n + 1)) == sqrt(8 * n + 1)


def sumchar(s):
    return sum(ord(c) - 64 for c in s)


ans = 0
words = eval('[' + open('assets/042.txt').readlines()[0] + ']')
for word in words:
    if istri(sumchar(word)):
        ans += 1
print(ans)