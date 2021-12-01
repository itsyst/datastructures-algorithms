def sort_array(array):
    for i in range(1, len(array)):
        current = array[i]
        j = i - 1
        while j >= 0 and array[j] > current:
            swap_array(array, j+1, j)
            j -= 1

        array[j+1] = current

    return array

def swap_array(array, index1, index2):
    temp = array[index1]
    array[index1] = array[index2]
    array[index2] = temp


numbers = [141, 0, 12, -1, -10, -27, 18, 233, 8, 7, 7]
print(sort_array(numbers))
