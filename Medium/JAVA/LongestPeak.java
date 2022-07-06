/**
 * LongestPeak
 */
public class LongestPeak {

    private static int longestPeak(int[] array) {
        int longestPeakLength = 0;
        int i = 1;
        while (i < array.length - 1) {
            boolean isPeak = array[i - 1] < array[i] && array[i] > array[i + 1];
            
            if(!isPeak)
                i += 1;
            
            int leftIndex = i - 2;
            while (leftIndex >= 0 && array[leftIndex] < array[leftIndex + 1]) {
                leftIndex -= 1;
            }
        }
        return longestPeakLength;
    }

    public static void main(String[] args) {
        int[] array = new int[] { 3, 5, 1 };
        var result = LongestPeak.longestPeak(array);
        System.out.println(result);
    }

}