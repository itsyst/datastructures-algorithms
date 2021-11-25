import java.util.Arrays;
import java.util.Collections;

/**
 * TotalSpeedBicycle
 */
public class TotalSpeedBicycle {

    private static int TandemBicycle(int[] redTeam, int[] blueTeam, boolean fastest) {
        Arrays.sort(redTeam);
        Arrays.sort(blueTeam);

        if (fastest)
            Collections.reverse(Arrays.asList(blueTeam));

        int totalMaxSpeed = 0;
        for (int i = 0; i < blueTeam.length; i++)
            totalMaxSpeed += Math.max(redTeam[i], blueTeam[i]);

        return totalMaxSpeed;
    }

    public static void main(String[] args) {
        int[] redTeam = new int[] { 3, 4, 4, 1, 1, 8, 9 };
        int[] blueTeam = new int[] { 9, 8, 2, 2, 3, 5, 6 };
        boolean fastest = false;
        int result = TotalSpeedBicycle.TandemBicycle(redTeam, blueTeam, fastest);
        System.out.println(result);
    }
}