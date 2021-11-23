class QuickSort {
    quickSort = (array) => {
        this.quickSortHelper(array, 0, array.length - 1);
    }

    quickSortHelper = (array, start, end) => {
        if (start >= end)
            return;

        var boundary = this.partition(array, start, end);

        this.quickSortHelper(array, start, boundary - 1);
        this.quickSortHelper(array, boundary + 1, end);
    }

    partition = (array, start, end) => {
        var pivot = array[end];
        var boundary = start - 1;
        for (var i = start; i <= end; i++) {
            if (array[i] <= pivot)
                this.swap(array, i, ++boundary);
        }
        return boundary;
    }

    swap = (array, index1, index2) => {
        const temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }
}

const minimumWaitingTime = (queries) => {
    queries.sort();
    let sum = 0;
    for (let i = 0; i < queries.length; i++)
        sum += queries[i] * ((queries.length - 1) - i);

    return sum;
}

const minimumWaitingTime2 = (queries) => {
    var sort = new QuickSort();
    sort.quickSort(queries);
    let sum = 0;
    for (let i = 0; i < queries.length; i++)
        sum += queries[i] * ((queries.length - 1) - i);

    return sum;
}



var queries = [4, 3, 1, 1, 3, 2, 1, 8];
var result = minimumWaitingTime2(queries);
console.log(result);