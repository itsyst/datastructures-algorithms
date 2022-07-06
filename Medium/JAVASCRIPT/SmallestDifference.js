// O(n^2) time | O(1) space
const smallestDifference1 = (arrayOne, arrayTwo) => {
    const smallestDiffPair =[];
    let smallestDiff = Infinity;

    for (let i = 0; i < arrayOne.length; i++)
        for (let j = 0; j < arrayTwo.length; j++) {
            let difference = Math.abs(arrayOne[i] - arrayTwo[j]);
            if (difference < smallestDiff) {
                smallestDiff = difference;
                smallestDiffPair[0] = arrayOne[i];
                smallestDiffPair[1] = arrayTwo[j];
            }
        }

    return smallestDiffPair;
}

// O(nlog(n) +mlog(m)) time | O(1) space
const smallestDifference2 = (arrayOne, arrayTwo) => {
    arrayOne.sort((a, b) => a - b);
    arrayTwo.sort((a, b) => a - b);

    const smallestDiffPair = [];
    let smallestDiff = Infinity;

    let arrayOneIndex = 0;
    let arrayTwoIndex = 0;

    while (arrayOneIndex < arrayOne.length && arrayTwoIndex < arrayTwo.length) {
        let difference = Math.abs(arrayOne[arrayOneIndex] - arrayTwo[arrayTwoIndex]);
        if (difference < smallestDiff) {
            smallestDiff = difference;
            smallestDiffPair[0] = arrayOne[arrayOneIndex];
            smallestDiffPair[1] = arrayTwo[arrayTwoIndex];
        }
        if (arrayOne[arrayOneIndex] < arrayTwo[arrayTwoIndex])
            arrayOneIndex++;
        else
            arrayTwoIndex++;
    }

    return smallestDiffPair;
}

const one = [10, 1000, 9124, 2142, 59, 24, 596, 591, 124, -123, 530];
const two = [-1441, -124, -25, 1014, 1500, 660, 410, 245, 530];
const result = smallestDifference2(one, two);
console.log(result);


