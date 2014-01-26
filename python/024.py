import itertools
print((''.join(next(itertools.islice(itertools.permutations('0123456789'), 999999, 1000000)))))
