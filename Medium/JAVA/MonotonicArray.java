/**
 * MonotonicArray
 */
public class MonotonicArray {

    public static boolean isMonotonic(int[] array) {
        if (array.length <= 2)
            return true;

        Boolean increasing = true;
        Boolean decreasing = true;

        for (int i = 1; i < array.length; i++) {
            if (array[i - 1] > array[i])
                increasing = false;

            if (array[i - 1] < array[i])
                decreasing = false;
        }

        return increasing || decreasing;
    }

    public static void main(String[] args) {
        int[] array = new int[] { -1, -5, -10, -1100, -1100, -1101, -1102, -9001 };
        var result = MonotonicArray.isMonotonic(array);
        System.out.println(result);
    }
}