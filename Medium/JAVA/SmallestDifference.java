import java.util.Arrays;

/**
 * SmallestDifference
 */
public class SmallestDifference {
    // O(n^2) time | O(1) space
    public static int[] smallestDifference1(int[] arrayOne, int[] arrayTwo) {
        int[] smallestDiffPair = new int[2];
        int smallestDiff = Integer.MAX_VALUE;

        for (int i = 0; i < arrayOne.length; i++)
            for (int j = 0; j < arrayTwo.length; j++) {
                int difference = Math.abs(arrayOne[i] - arrayTwo[j]);
                if (difference < smallestDiff) {
                    smallestDiff = difference;
                    smallestDiffPair[0] = arrayOne[i];
                    smallestDiffPair[1] = arrayTwo[j];
                }
            }

        return smallestDiffPair;
    }
    
    // O(nlog(n) +mlog(m)) time | O(1) space
    public static int[] smallestDifference2(int[] arrayOne, int[] arrayTwo) {
        Arrays.sort(arrayOne);
        Arrays.sort(arrayTwo);

        int[] smallestDiffPair = new int[2];
        int smallestDiff = Integer.MAX_VALUE;

        int arrayOneIndex = 0;
        int arrayTwoIndex = 0;

        while (arrayOneIndex < arrayOne.length && arrayTwoIndex < arrayTwo.length) {
            int difference = Math.abs(arrayOne[arrayOneIndex] - arrayTwo[arrayTwoIndex]);
            if (difference < smallestDiff) {
                smallestDiff = difference;
                smallestDiffPair[0] = arrayOne[arrayOneIndex];
                smallestDiffPair[1] = arrayTwo[arrayTwoIndex];
            }
            if (arrayOne[arrayOneIndex] < arrayTwo[arrayTwoIndex])
                arrayOneIndex++;
            else
                arrayTwoIndex++;
        }

        return smallestDiffPair;
    }
    public static void main(String[] args) {
        int[] one = new int[] { 10, 1000, 9124, 2142, 59, 24, 596, 591, 124, -123, 530 };
        int[] two = new int[] { -1441, -124, -25, 1014, 1500, 660, 410, 245, 530 };
        int[] result = SmallestDifference.smallestDifference2(one, two);
        System.out.println(Arrays.toString(result));
    }
    
}