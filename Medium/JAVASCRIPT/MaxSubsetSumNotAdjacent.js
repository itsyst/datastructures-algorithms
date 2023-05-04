function maxSubsetSumNoAdjacent(array) {
    if (array.length === 0) {
        return 0;
    }

    if (array.length === 1) {
        return array[0];
    }

    const dp = new Array(array.length);
    dp[0] = array[0];
    dp[1] = Math.max(array[0], array[1]);

    for (let i = 2; i < array.length; i++) {
        dp[i] = Math.max(dp[i - 1], dp[i - 2] + array[i]);
    }

    return dp[array.length - 1];
}

const array = [75, 105, 120, 75, 90, 135];
const maxSum = maxSubsetSumNoAdjacent(array);
console.log(maxSum);  // Output: 330
