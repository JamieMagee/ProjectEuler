f = open('assets/013.txt')
num = []
for line in f:
    num.append(int(line))
print((str(sum(num))[:10]))
