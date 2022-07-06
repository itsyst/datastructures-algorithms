def spiral_traverse(matrix):
    numbers = []

    if len(matrix) == 0:
        return numbers

    i = 0
    start_row_index = 0
    end_row_index = len(matrix)
    start_col_index = 0
    end_col_index = len(matrix[0])

    while start_row_index < end_row_index and start_col_index < end_col_index:
        for i in range(start_col_index, end_col_index):
            numbers.append(matrix[start_row_index][i])
        start_row_index += 1

        for i in range(start_row_index, end_row_index):
            numbers.append(matrix[i][end_col_index - 1])
        end_col_index -= 1

        if (start_row_index < end_row_index):
            for i in range(end_col_index - 1, start_col_index-1, -1):
                numbers.append(matrix[end_row_index - 1][i])
        end_row_index -= 1

        if (start_col_index < end_col_index):
            for i in range(end_row_index - 1, start_row_index-1, -1):
                numbers.append(matrix[i][start_col_index])

        start_col_index += 1

    return numbers


array = [
    [1, 2, 3, 4],
    [12, 13, 14, 5],
    [11, 16, 15, 6],
    [10, 9, 8, 7],
]
result = spiral_traverse(array)
print(result)
