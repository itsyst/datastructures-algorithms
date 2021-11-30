const CAPACITY = 3;
const getLargestNumbers = (array) => {
    array.sort((a, b) => a - b);
    let subArray = [...Array(CAPACITY)];
    // let subArray = new Array(CAPACITY).fill(0);
    let j = 0;
    for (let i = 0; i < array.length; i++)
        if (i >= array.length - CAPACITY)
            subArray.splice(j++, 1, array[i]);

    return subArray;
}


const getThreeLargestNumbers = (array) => {
    const threeLargestNumbers = [null, null, null];
    for (const number of array)
        validate(threeLargestNumbers, number);

    return threeLargestNumbers;
}

const validate = (array, number) => {
    if (array[2] === null || number > array[2])
        update(array, number, 2);
    else if (array[1] === null || number > array[1])
        update(array, number, 1);
    else if (array[0] === null || number > array[0])
        update(array, number, 0);

}

const update = (array, number, index) => {
    for (let i = 0; i <= index; i++)
        if (i === index) array[i] = number;
        else array[i] = array[i + 1];
}




const numbers = [141, 1, 17, -7, -17, -27, 18, 541, 8, 7, 7];
// const result = getLargestNumbers(numbers);
const result = getThreeLargestNumbers(numbers);
console.log(result);