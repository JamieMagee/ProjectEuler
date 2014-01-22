f = open('assets/067.txt')
l = [map(int, line.split(' ')) for line in f]
for i in range(1, len(l)):
    for j in range(0, i + 1):
        if j is 0:
            l[i][j] += l[i - 1][j]
        elif j is i:
            l[i][j] += l[i - 1][j - 1]
        else:
            l[i][j] += max(l[i - 1][j], l[i - 1][j - 1])

ans = 0
for i in range(0, len(l)):
    if l[len(l)-1][i] > ans:
        ans = l[len(l)-1][i]
print(ans)