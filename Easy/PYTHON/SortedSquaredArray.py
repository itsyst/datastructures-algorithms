def sorted_squared_array1(array):
    sorted = [0 for _ in array]
    for i in range(0, len(array)):
        sorted[i] = pow(array[i], 2)

    sorted.sort()

    return sorted


def sorted_squared_array2(array):
    sorted = [0 for _ in array]
    start = 0
    end = len(array) - 1
    for i in reversed(range(len(array))):
        smallValue = array[start]
        largeValue = array[end]

        if abs(smallValue > largeValue):
            sorted[i] = smallValue * smallValue
            start += 1
        else:
            sorted[i] = largeValue * largeValue
            end -= 1

    return sorted


result = sorted_squared_array2([1, 5, 6, 8, 3])
print(result)
