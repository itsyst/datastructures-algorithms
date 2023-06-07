using System;
using System.Linq;

public class MinReward {
    public static int MinRewards(int[] scores) {
        int n = scores.Length;
        int[] rewards = new int[n];
        Array.Fill(rewards, 1);

        for (int i = 1; i < n; i++) {
            if (scores[i] > scores[i - 1]) {
                rewards[i] = rewards[i - 1] + 1;
            }
        }

        for (int i = n - 2; i >= 0; i--) {
            if (scores[i] > scores[i + 1]) {
                rewards[i] = Math.Max(rewards[i], rewards[i + 1] + 1);
            }
        }

        return rewards.Sum();
    }
}
