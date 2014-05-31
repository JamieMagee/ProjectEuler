def ispalindrome(word):
    return word == word[::-1]


ans = 0
for i in range(10000):
    num, iterations = i, 0
    num += int(str(num)[::-1])
    while iterations < 50 and not ispalindrome(str(num)):
        num += int(str(num)[::-1])
        iterations += 1
    if not ispalindrome(str(num)):
        ans += 1
print(ans)