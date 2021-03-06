def is_monotonic1(array):
    increasing = True
    decreasing = True

    for i in range(1, len(array)):
        if(array[i] < array[i - 1]):
            increasing = False
        if(array[i] > array[i - 1]):
            decreasing = False

    return increasing or decreasing


def is_monotonic2(array):
    if (len(array) <= 2):
        return True

    return (all(array[i - 1] <= array[i] for i in range(1, len(array))) or
            all(array[i - 1] >= array[i] for i in range(1, len(array))))


array = [-1, -5, -10, -1100, -1100, -1101, -1102, -9001]
result = is_monotonic1(array)
print(result)
