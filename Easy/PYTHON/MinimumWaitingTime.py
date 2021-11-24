def minimum_waiting_time1(array):
    sorted_queries = sorted(array)
    sum = 0
    for i in range(0, len(sorted_queries)):
        sum += sorted_queries[i] * ((len(sorted_queries) - 1) - i)

    return sum


def minimum_waiting_time2(array):
    array.sort()
    totalWaitingTime = 0
    for idx, duration in enumerate(array):
        totalWaitingTime += duration * (len(array) - (1 + idx))

    return totalWaitingTime


queries = [17, 3, 4]
result = minimum_waiting_time2(queries)
print(result)
