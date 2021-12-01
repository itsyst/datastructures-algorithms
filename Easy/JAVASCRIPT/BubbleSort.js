// O(n^2) time where n is the length of array | O(1) space
const sort = (array) => {
    if (array.length === 0)
        return [];

    let isSorted = false;
    for (let i = 0; i < array.length; i++) {
        isSorted = true;
        for (let j = 1; j < array.length - i; j++) {
            if (array[j] < array[j - 1]) {
                swap(array, j, j - 1);
                isSorted = false;
            }
        }
        // swapped by inner loop, then break
        if (isSorted === true)
            break;
    }

    return array;
}

const swap = (array, index1, index2) => {
    let temp = array[index1];
    array[index1] = array[index2];
    array[index2] = temp;
}


let numbers = [141, 0, 12, -1, -10, -27, 18, 233, 8, 7, 7];
const result = sort(numbers);
console.log(result);