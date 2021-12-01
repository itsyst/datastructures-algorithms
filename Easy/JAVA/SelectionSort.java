import java.util.Arrays;

public class SelectionSort {
    public static int[] sort(int[] array) {
        if (array.length == 0)
            return new int[] {};

        for (int i = 0; i < array.length; i++) {
            int minIndex = findMinIndex(array, i);
            swap(array, minIndex, i);
        }

        return array;
    }

    private static int findMinIndex(int[] array, int i) {
        int minIndex = i;
        for (int j = i + 1; j < array.length; j++) {
            if (array[j] < array[minIndex])
                minIndex = j;
        }
        return minIndex;
    }

    private static int findMaxIndex(int[] array, int i) {
        int minIndex = i;
        for (int j = i + 1; j < array.length; j++) {
            if (array[j] > array[minIndex])
                minIndex = j;
        }
        return minIndex;
    }

    private static void swap(int[] array, int index1, int index2) {
        int temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }

    public static void main(String[] args) {
        int[] numbers = new int[] { 0, 12, -1, -10, -27, 18, 233, 8, 5, 7 };
        int[] result = SelectionSort.sort(numbers);
        System.out.println(Arrays.toString(result));
    }

}