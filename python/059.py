def decrypt(key):
    plaintext = [''] * len(ciphertext)
    for i in range(len(ciphertext)):
        plaintext[i] = unichr(ciphertext[i] ^ key[i % len(key)])
    return plaintext


def getscore(plaintext):
    sum = 0
    for i in range(len(plaintext)):
        if 'A' <= plaintext[i] <= 'Z':
            sum += 1
        elif 'a' <= plaintext[i] <= 'z':
            sum += 2
        elif plaintext[i] < 0x20 or plaintext[i] == 0x7F:
            sum -= 10
    return sum


bestscore = 0
ciphertext = [int(c) for c in open('../assets/059.txt').readline().split(',')]
for a in range(ord('a'), ord('z')):
    for b in range(ord('a'), ord('z')):
        for c in range(ord('a'), ord('z')):
            if getscore(decrypt([a, b, c])) > bestscore:
                ans = decrypt([a, b, c])
                bestscore = getscore(decrypt([a, b, c]))
print(sum(ord(c) for c in ans))