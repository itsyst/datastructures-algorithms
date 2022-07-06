def move_element_to_end(array, to_move):
    index = len(array) - 1
    for i in range(len(array) - 1, -1, -1):
        if array[i] == to_move:
            swap(array, i, index)
            index -= 1

    return array


def swap(array, index1, index2):
    temp = array[index1]
    array[index1] = array[index2]
    array[index2] = temp
    return array


array = [2, 1, 2, 2, 2, 3, 4, 2]
to_move = 2
result = move_element_to_end(array, to_move)
print(result)
