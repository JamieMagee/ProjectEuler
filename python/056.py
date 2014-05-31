ans = 0
for a in range(1, 100):
    for b in range(1, 100):
        ans = max(ans, sum(int(x) for x in str(a ** b)))
print(ans)