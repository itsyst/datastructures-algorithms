package JAVA;
import java.util.Arrays;

class NonConstructibleChange {
    // O(nlogn(n)) | O(1)
    private static int nonConstructibleChange(int[] coins) {
        Arrays.sort(coins);
        int currentCoinChange = 0;
        for (int coin : coins) {
            if (coin > currentCoinChange + 1)
                return currentCoinChange += 1;

            currentCoinChange += coin;
        }

        return currentCoinChange + 1;
    }

    public static void main(String[] args) {
        int[] array = new int[] { 1, 2, 5};
        int result = nonConstructibleChange(array);
        System.out.println(result);
    }
}