
from typing import Set


def three_number_sum1(array, targetSum):
    triples = []
    array.sort()

    for i in range(0, len(array) - 2):
        for j in range(i+1, len(array) - 1):
            for k in range(j+1, len(array)):
                current_sum = array[i] + array[j] + array[k]
                if (current_sum == targetSum):
                    triples.append([array[i], array[j], array[k]])

    return triples


def three_number_sum2(array, target_sum):
    triples = []
    array.sort()

    for i in range(0, len(array) - 2):
        left = i + 1
        right = len(array) - 1
        while (left < right):
            current_sum = array[left] + array[i] + array[right]
            if (current_sum == target_sum):
                triples.append([array[i], array[left], array[right]])
                left += 1
                right -= 1
            elif current_sum < target_sum:
                left += 1
            else:
                right -= 1

    return triples


def three_number_sum3(array, target_sum):
    triples = []
    array.sort()

    for i in range(0, len(array) - 2):
        # Find pair in sub array array[i+1..n-1]s
        # with targetSum equal to currentSum - array[i]
        set = {}
        current_sum = target_sum - array[i]
        for j in range(i+1, len(array)):
            if set.__contains__(current_sum - array[j]):
                triples.append([array[i], current_sum - array[j], array[j]])

            set[array[j]] = True

    return triples


array = [12, 3, 1, 2, -6, 5, -8, 6]
target = 0
result = three_number_sum3(array, target)
print(result)
