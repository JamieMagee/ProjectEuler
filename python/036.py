def ispalindrome(n):
    return str(n) == str(n)[::-1]

ans = 0
for i in range(1000000):
    if ispalindrome(i) and ispalindrome(bin(i)[2:]):
        ans += i
print(ans)