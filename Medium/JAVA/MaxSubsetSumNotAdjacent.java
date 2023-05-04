public class MaxSubsetSumNotAdjacent {
    public static int maxSubsetSumNoAdjacent(int[] array) {
        if (array.length == 0) {
            return 0;
        }

        if (array.length == 1) {
            return array[0];
        }

        int[] dp = new int[array.length];
        dp[0] = array[0];
        dp[1] = Math.max(array[0], array[1]);

        for (int i = 2; i < array.length; i++) {
            dp[i] = Math.max(dp[i - 1], dp[i - 2] + array[i]);
        }

        return dp[array.length - 1];
    }

    public static void main(String[] args) {
        int[] array = { 75, 105, 120, 75, 90, 135 };
        int maxSum = maxSubsetSumNoAdjacent(array);
        System.out.println(maxSum);  // Output: 330
    }
}
