using System;

public class StaircaseTraversals {
    public int StaircaseTraversal(int height, int maxSteps) {
        int[] dp = new int[height + 1];
        dp[0] = 1;

        for (int i = 1; i <= height; i++) {
            for (int j = 1; j <= maxSteps && j <= i; j++) {
                dp[i] += dp[i - j];
            }
        }

        return dp[height];
    }
}
