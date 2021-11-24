const rowRange = (redShirtStudents, blueShirtStudents) => {
    redShirtStudents.sort((a, b) => a - b).reverse();
    blueShirtStudents.sort((a, b) => a - b).reverse();

    for (let index = 0; index < redShirtStudents.length; index++) {
        if (redShirtStudents[0] > blueShirtStudents[0]) {
            if (redShirtStudents[index] <= blueShirtStudents[index]) {
                return false;
            }
        } else {
            if (redShirtStudents[index] >= blueShirtStudents[index]) {
                return false;
            }
        }

    }

    return true;
}

redRow = [19, 19, 21, 1, 1, 1, 1, 1];
blueRow = [20, 5, 4, 4, 4, 4, 4, 4];
var result = rowRange(redRow, blueRow);
console.log(result);