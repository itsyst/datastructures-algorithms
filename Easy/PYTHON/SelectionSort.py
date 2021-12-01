# O(n ^ 2) time where n is the length of array | O(1) space
def sort(array):
    if (len(array) == 0):
        return []

    for i in range(0, len(array)):
        maxIndex = findMaxIndex(array, i)
        swap(array, maxIndex, i)

    return array


def findMinIndex(array, i):
    minIndex = i
    for j in range(i+1, len(array)):
        if array[j] < array[minIndex]:
            minIndex = j

    return minIndex


def findMaxIndex(array, i):
    maxIndex = i
    for j in range(i+1, len(array)):
        if array[j] > array[maxIndex]:
            maxIndex = j

    return maxIndex


def swap(array, index1, index2):
    temp = array[index1]
    array[index1] = array[index2]
    array[index2] = temp
 


numbers = [141, 0, 12, -1, -10, -27, 18, 233, 8, 7, 7]
result = sort(numbers)
print(result)
