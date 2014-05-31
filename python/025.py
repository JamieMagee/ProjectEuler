def fib():
    a, b = 0, 1
    while True:
        yield a
        a, b = b, a + b


ans = next(i for (i, f) in enumerate(fib()) if len(str(f)) >= 1000)
print(ans)