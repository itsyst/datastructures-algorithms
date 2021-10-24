// O(n^2) time | O(1) space
function twoNumberSum1(array, targetSum) {
  for (let i = 0; i < array.length - 1; i++) {
    const first = array[i];
    for (let j = i + 1; j < array.length; j++) {
      const second = array[j]
      if (first + second === targetSum) {
        return [second, first];
      }
    }

  }
  return [];
}

// O(n) | O(n) space
 function twoNumberSum2(array, targetSum) {
  const numbers = [];
  for (const number of array) {
    const complement = targetSum - number;
    if (numbers.includes(complement)) {
      return [complement, number]
    } else {
      numbers.push(number);
    }
  }
  return [];
}

// O(n) | O(n) space
function twoNumberSum3(array, targetSum) {
  const numbers = {};
  for (const number of array) {
    const complement = targetSum - number;
    if (complement in numbers) {
      return [number, complement]
    } else {
      numbers[number] = true;
    }
  }
  return [];
}

// O(n log(n)) | O(1) space
function twoNumberSum4(array, targetSum) {
  let left = 0;
  let right = array.length - 1;
  while (left < right) {
    const currentSum = array[left] + array[right];
    if (currentSum < targetSum)
      left++;
    else if (currentSum > targetSum)
      right--;
    else if (currentSum == targetSum)
      return [array[left], array[right]]
  }
  return [];
}

const result = twoNumberSum3([3, 5, -4, 8, 11, 1, -1, 6], 10);
console.log(result);


