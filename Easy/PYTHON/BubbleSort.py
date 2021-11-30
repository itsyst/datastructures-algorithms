def sort(array):
    if len(array) == 0:
        return []

    isSorted = False
    for i in range(0, len(array)):
        isSorted = True
        for j in range(1, len(array) - i):
            if array[j] < array[j-1]:
                swap(array, j, j-1)
                isSorted = False

        if isSorted == True:
            break

    return array


def swap(array, index1, index2):
    temp = array[index1]
    array[index1] = array[index2]
    array[index2] = temp


numbers = [141, 1, 17, -7, -17, -27, 18, 541, 8, 7, 7]
result = sort(numbers)
print(result)
