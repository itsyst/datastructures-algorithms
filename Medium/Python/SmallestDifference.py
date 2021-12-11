# O(n^2) time | O(1) space
def smallest_difference_1(arrayOne, arrayTwo):
    smallestDiff = float('inf')

    for i in range(len(arrayOne)):
        for j in range(len(arrayTwo)):
            difference = abs(arrayOne[i] - arrayTwo[j])
            if difference < smallestDiff:
                smallestDiff = difference
                smallestDiffPair = [arrayOne[i], arrayTwo[j]]
 
    return smallestDiffPair


# O(nlog(n) +mlog(m)) time | O(1) space
def smallest_difference_2(arrayOne, arrayTwo):
    arrayOne.sort()
    arrayTwo.sort()

    smallestDiff = float('inf')
    arrayOneIndex = 0
    arrayTwoIndex = 0

    while arrayOneIndex < len(arrayOne) and arrayTwoIndex < len(arrayTwo):
        difference = abs(arrayOne[arrayOneIndex] - arrayTwo[arrayTwoIndex])
        if difference < smallestDiff:
            smallestDiff = difference
            smallestDiffPair = [arrayOne[arrayOneIndex], arrayTwo[arrayTwoIndex]]
        elif arrayOne[arrayOneIndex] < arrayTwo[arrayTwoIndex]:
            arrayOneIndex += 1
        else:
            arrayTwoIndex += 1

    return smallestDiffPair


one = [10, 1000, 9124, 2142, 59, 24, 596, 591, 124, -123, 530]
two = [-1441, -124, -25, 1014, 1500, 660, 410, 245, 530]
result = smallest_difference_2(one, two)
print(result)
