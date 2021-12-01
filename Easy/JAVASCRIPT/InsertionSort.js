class InsertionSort {
    sort = (array) => {
        for (let i = 1; i < array.length; i++) {
            const current = array[i];
            let j = i - 1;

            while (j >= 0 && array[j] > current) {
                this.swap(array, j + 1, j);
                j--;
            }
            array[j + 1] = current;
        }

        return array;
    }

    swap = (array, index1, index2) => {
        const temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;

    }
}


const numbers = [141, 0, 12, -1, -10, -27, 18, 233, 8, 7, 7];
const sorted = new InsertionSort();
console.log(sorted.sort(numbers));