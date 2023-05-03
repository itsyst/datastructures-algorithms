import random


def main():
    array = [12, 11, 13, 5, 6, 7]
    k = 3

    kth_smallest = quickselect(array, k)
    print(f"The {k}th smallest element is: {kth_smallest}")


def quickselect(array, k):
    return _quickselect(array, 0, len(array) - 1, k - 1)


def _quickselect(array, left, right, k):
    if left == right:
        return array[left]

    pivot_index = random.randint(left, right)
    pivot_index = partition(array, left, right, pivot_index)

    if k == pivot_index:
        return array[k]
    elif k < pivot_index:
        return _quickselect(array, left, pivot_index - 1, k)
    else:
        return _quickselect(array, pivot_index + 1, right, k)


def partition(array, left, right, pivot_index):
    pivot_value = array[pivot_index]
    array[pivot_index], array[right] = array[right], array[pivot_index]

    store_index = left
    for i in range(left, right):
        if array[i] < pivot_value:
            array[store_index], array[i] = array[i], array[store_index]
            store_index += 1

    array[right], array[store_index] = array[store_index], array[right]
    return store_index


if __name__ == "__main__":
    main()
