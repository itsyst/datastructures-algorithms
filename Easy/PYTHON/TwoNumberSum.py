# O(n ^ 2) | O(1) space
def twoNumberSum1(array, targetSum):
    for i in range(0, len(array) - 1):
        first = array[i]
        for j in range(i+1, len(array)):
            second = array[j]
            if first + second == targetSum:
                return [first, second]

    return []

# O(n ^ 2) | O(1) space


def twoNumberSum2(array, targetSum):
    set = {}
    for num in array:
        complement = targetSum - num
        if set.__contains__(complement):
            return [complement, num]

        set[num] = True

    return []

#  O(n log(n)) | O(1) space


def twoNumberSum3(array, targetSum):
    left = 0
    right = len(array) - 1
    while left < right:
        currentSum = array[left] + array[right]
        if currentSum < targetSum:
            left += 1
        elif currentSum > targetSum:
            right -= 1
        else:
            return [array[right], array[left]]

    return []


result = twoNumberSum3([3, 5, -4, 8, 11, 1, -1, 6], 10)
print(result)
