const moveElementToEnd = (array, toMove) => {
    let index = array.length - 1;
    for (let i = array.length - 1; i >= 0; i--)
        if (array[i] == toMove)
            swap(array, i, index--);

    return array;
}

const swap = (array, index1, index2) => {
    const temp = array[index1];
    array[index1] = array[index2];
    array[index2] = temp;
}

let array = [2, 1, 2, 2, 2, 3, 4, 2];
const toMove = 2;
const result = moveElementToEnd(array, toMove);
console.log(result)

