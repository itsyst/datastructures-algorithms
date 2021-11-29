import math

def binary_search(array, target):
    return binary_search_helper(array, target, 0, len(array) - 1)


def binary_search_helper(array, target, left, right):
    if left > right:
        return -1

    middle =  math.floor((left + right) / 2)

    if target == array[middle]:
        return middle

    if target < array[middle]:
        return binary_search_helper(array, target, left, middle - 1)

    return binary_search_helper(array, target, middle + 1, right)


array = [0, 1, 21, 33, 45, 45, 61, 71, 72, 73]
result = binary_search(array, 33)
print(result)
