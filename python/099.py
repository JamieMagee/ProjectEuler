import math
f = open('../assets/099.txt')
l = [map(int, line.split(',')) for line in f]
largest = 0
for base, exp in l:
    if exp*math.log(base) > largest:
        largest = exp*math.log(base)
        line = l.index([base, exp]) + 1
print(line)
