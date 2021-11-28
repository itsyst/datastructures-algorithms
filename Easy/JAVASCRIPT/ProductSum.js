const productSum = (array) => {
    return productSumHelper(1, array);
}

const productSumHelper = (factor, array) => {
    sum = 0;
    for (const element of array) {
        // Check if the element is an integer or a list
        if (Array.isArray(element))
            sum += productSumHelper(factor + 1, element);
        else
            sum += element;
    }
    return sum * factor;
}

const specialArray = [5, 2, [7, -1], 3, [6, [-13, 8], 4]];
const result = productSum(specialArray);
console.log(result);