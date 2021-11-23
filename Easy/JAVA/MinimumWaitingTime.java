package Easy.JAVA;

import java.util.Arrays;

public class MinimumWaitingTime {

    // O(nlog(n)) | O(1)
    private static int waitingTime(int[] queries) {
        Arrays.sort(queries);
        var sum = 0;
        for (int i = 0; i < queries.length; i++) {
            sum += queries[i] * ((queries.length - 1) - i);
        }
        return sum;
    }

    public static void main(String[] args) {

        var times = new int[] { 17, 4, 3 };
        var result = waitingTime(times);
        System.out.println(result);
    }
}
