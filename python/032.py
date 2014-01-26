def ispandigital(i, j, k):
    return '123456789' == ''.join(sorted(str(i) + str(j) + str(k)))

ans = set()
for i in range(1, 2000):
    for j in range(1, 50):
        product = i * j
        if ispandigital(product, i, j):
            ans.add(product)
print((sum(ans)))