// O(n log(n)) | O(n) space
sortedSquaredArray1 = (array) => {
    const sorted = [];
    for (let i = 0; i < array.length; i++) {
        sorted[i] = Math.pow(array[i], 2);
    }
    sorted.sort((num1, num2) => { num1 - num2 });
    return sorted;
}

// O(n) time | O(n) space
sortedSquaredArray2 = (array) => {
    const sorted = [];
    let start = 0;
    let end = array.length - 1;
    for (let i = array.length - 1; i >= 0; i--) {
        if (array[start] < array[end]) {
            sorted[i] = array[end];
            end--;
        } else {
            sorted[i] = array[start];
            start++;
        }
    }

    return sorted;
}

const result = sortedSquaredArray1([1, 2, 3, 5, 6, 8, 9]);
console.log(result);