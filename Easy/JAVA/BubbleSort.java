import java.util.Arrays;

public class BubbleSort {

    // O(n^2) time where n is the length of array | O(1) space
    public static int[] sort(int[] array) {
        if (array.length == 0)
            return new int[] {};

        Boolean isSorted;
        for (int i = 0; i < array.length; i++) {
            isSorted = true;
            for (int j = 1; j < array.length - i; j++) {
                if (array[j] < array[j - 1]) {
                    swap(array, j, j - 1);
                    isSorted = false;
                }
            }
            // swapped by inner loop, then break
            if (isSorted == true)
                break;
        }

        return array;
    }

    private static void swap(int[] array, int index1, int index2) {
        int temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }

    public static void main(String[] args) {
        int[] numbers = new int[] { 141, 0, 12, -1, -10, -27, 18, 233, 8, 7, 7 };
        int[] result = BubbleSort.sort(numbers);
        System.out.println(Arrays.toString(result));

    }
}