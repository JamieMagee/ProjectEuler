for i in range(100000, 1000000):
    nums = [sorted(str(i*j)) for j in range(1, 7)]
    if all(nums[0] == item for item in nums):
        print(i)
        break