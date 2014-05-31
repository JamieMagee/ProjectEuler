from collections import defaultdict

cubes = defaultdict(list)
for i in range(10000):
    digits = ''.join(sorted([d for d in str(i ** 3)]))
    cubes[digits].append(str(i ** 3))
print(min([min(v) for k, v in list(cubes.items()) if len(v) == 5]))
