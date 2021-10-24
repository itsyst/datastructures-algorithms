// O(n) | O(1) space
function isValidSubsequence1(array, sequence) {
  var arrayIndex = 0;
  var sequenceIndex = 0;
  while (arrayIndex < array.length && sequenceIndex < sequence.length) {
    if (array[arrayIndex] === sequence[sequenceIndex])
      sequenceIndex++;

    arrayIndex++;
  }
  return sequenceIndex == sequence.length;
}

// O(n) | O(1) space
function isValidSubsequence2(array, sequence) {
  var sequenceIndex = 0;
  for (const number of array) {
    if (sequenceIndex === sequence.length)
      break;
    if (sequence[sequenceIndex] === number)
      sequenceIndex++;
  }

  return sequenceIndex == sequence.length;
}

// O(n) | O(1) space
function isValidSubsequence3(array, sequence) {
  var sequenceIndex = 0;
  array.forEach(element => {
    if (sequence[sequenceIndex] === element)
      sequenceIndex++;
    if (sequenceIndex === sequence.length)
      return;
  });

  return sequenceIndex == sequence.length;
}

var array = [5, 1, 22, 25, 6, -1, 8, 10];
var sequence = [1, 6, -1, 10];
var result = isValidSubsequence2(array, sequence);
console.log(result);