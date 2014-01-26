from itertools import permutations

pandigital = list(permutations(['0', '1', '2', '3', '4', '5', '6', '7', '8', '9'], 10))
sum = 0
for num in pandigital:
    if int(''.join(num[1:4])) % 2 == 0 and int(''.join(num[2:5])) % 3 == 0 and int(''.join(num[3:6])) % 5 == 0 and int(
            ''.join(num[4:7])) % 7 == 0 and int(''.join(num[5:8])) % 11 == 0 and int(
            ''.join(num[6:9])) % 13 == 0 and int(''.join(num[7:10])) % 17 == 0:
        sum += int(''.join(num))
print(sum)