def is_monotonic(array):
    if (len(array) <= 2):
        return True

    return (all(array[i -1] <= array[i] for i in range(1, len(array))) or
            all(array[i -1] >= array[i] for i in range(1, len(array))))


array = [-1, -5, -10, -1100, -1100, -1101, -1102, -9001]
result = is_monotonic(array)
print(result)
