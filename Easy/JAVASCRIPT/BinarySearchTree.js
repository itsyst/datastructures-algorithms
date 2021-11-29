const binarySearch = (array, target) => {
    return binarySearchHelper(array, target, 0, array.length - 1);
}

const binarySearchHelper = (array, target, left, right) => {
    if (left > right)
        return -1;

    let middle = Math.ceil((left + right) / 2);

    if (target === array[middle])
        return middle;

    if (target < array[middle])
        return binarySearchHelper(array, target, left, middle - 1);

    return binarySearchHelper(array, target, middle + 1, right);
}

const array = [0, 1, 21, 33, 45, 45, 61, 71, 72, 73];
const result = binarySearch(array, 33);
console.log(result);