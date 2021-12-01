// O(n^2) time where n is the length of array | O(1) space
function sort(array) {
    if (array.length === 0)
        return [];

    for (let i = 0; i < array.length; i++) {
        let maxIndex = findMaxIndex(array, i);
        swap(array, maxIndex, i);
    }

    return array;
}

function findMinIndex(array, i) {
    let minIndex = i;
    for (let j = i + 1; j < array.length; i++) {
        if (array[j] < array[minIndex]) {
            minIndex = j;
        }
    }

    return minIndex;
}

function findMaxIndex(array, i) {
    let maxIndex = i;
    for (let j = i + 1; j < array.length; j++) {
        if (array[j] > array[maxIndex]) {
            maxIndex = j;
        }
    }

    return maxIndex;
}

function swap(array, index1, index2) {
    let temp = array[index1];
    array[index1] = array[index2];
    array[index2] = temp;
}


const numbers = [141, 0, 12, -1, -10, -27, 18, 233, 8, 7, 7];
const result = sort(numbers);
console.log(result);