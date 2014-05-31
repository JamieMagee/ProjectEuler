names = eval('[' + open('assets/022.txt').readlines()[0] + ']')
names.sort()
ans = 0
for i in range(len(names)):
    ans += sum([ord(c) - ord('A') + 1 for c in names[i]]) * (i + 1)
print(ans)