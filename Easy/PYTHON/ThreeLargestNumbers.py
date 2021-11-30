
CAPACITY = 3
# subArray = list(None for i in range(0, CAPACITY))
subArray = [None]*CAPACITY


def get_largest_numbers(array):
    array.sort()
    j = 0
    for i in range(0, len(array)):
        if i >= len(array) - CAPACITY:
            subArray[j] = array[i]
            j += 1

    return subArray


def get_three_largest_numbers(array):
    threeLargestNumbers = subArray
    for number in array:
        validate(threeLargestNumbers, number)

    return threeLargestNumbers


def validate(array, number):
    if array[2] is None or number > array[2]:
        update(array, number, 2)
    elif array[1] is None or number > array[1]:
        update(array, number, 1)
    elif array[0] is None or number > array[0]:
        update(array, number, 0)


def update(array, number, index):
    for i in range(index +1):
        if i == index:
            array[i] = number
        else:
            array[i] = array[i + 1]


numbers = [141, 1, 17, -7, -17, -27, 18, 541, 8, 7, 7]
# result = get_largest_numbers(numbers)
result = get_three_largest_numbers(numbers)
print(result)
