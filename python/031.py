coins = [1, 2, 5, 10, 20, 50, 100, 200]
ways = [0] * 201
ways[0] = 1
for i in range(0, 8):
    for j in range(coins[i], 201):
        ways[j] += ways[j - coins[i]]
print(ways[200])
