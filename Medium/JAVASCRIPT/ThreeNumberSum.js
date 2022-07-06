
const threeNumberSum1 = (array, targetSum) => {
    let triples = [];
    array.sort((a, b) => a - b);

    for (let i = 0; i < array.length - 2; i++) {
        for (let j = i + 1; j < array.length - 1; j++) {
            for (let k = j + 1; k < array.length; k++) {
                const currentSum = array[i] + array[j] + array[k];
                if (currentSum == targetSum)
                    triples.push([array[i], array[j], array[k]]);
            }
        }
    }
    return triples;
}

const threeNumberSum2 = (array, targetSum) => {
    let triples = [];
    array.sort((a, b) => a - b);

    for (let i = 0; i < array.length - 2; i++) {
        let left = i + 1;
        let right = array.length - 1;
        while (left < right) {
            const currentSum = array[left] + array[i] + array[right];
            if (currentSum == targetSum) {
                triples.push([array[i], array[left], array[right]]);
                left++;
                right--;
            } else if (currentSum < targetSum) {
                left++;
            }
            else {
                right--;
            }
        }
    }

    return triples;
}

const threeNumberSum3 = (array, targetSum) => {
    let triples = [];
    array.sort((a, b) => a - b);



    for (let i = 0; i < array.length - 2; i++) {
        // Find pair in sub array array[i+1..n-1]s
        // with targetSum equal to currentSum - array[i]
        let set = new Set();
        const currentSum = targetSum - array[i];
        for (let j = i + 1; j < array.length; j++) {
            if (set.has(currentSum - array[j]))
                triples.push([array[i], currentSum - array[j], array[j]]);

            set.add(array[j]);
        }
    }

    return triples;
}



const array = [12, 3, 1, 2, -6, 5, -8, 6];
const target = 0;
const result = threeNumberSum3(array, target);
console.log(result);