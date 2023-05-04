def maxSubsetSumNoAdjacent(array):
    length = len(array)

    if length == 0:
        return 0

    if length == 1:
        return array[0]

    dp = [0] * length
    dp[0] = array[0]
    dp[1] = max(array[0], array[1])

    for i in range(2, length):
        dp[i] = max(dp[i - 1], dp[i - 2] + array[i])

    return dp[length - 1]


array = [75, 105, 120, 75, 90, 135]
maxSum = maxSubsetSumNoAdjacent(array)
print(maxSum)  # Output: 330
