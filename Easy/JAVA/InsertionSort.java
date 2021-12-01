import java.util.Arrays;

public class InsertionSort {

    public static int[] sort(int[] array) {
        for (int i = 1; i < array.length; i++) {
            int current = array[i];
            int j = i - 1;
            while (j >= 0 && array[j] > current) {
                swap(array, j + 1, j);
                j--;
            }
            array[j + 1] = current;
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
        int[] result = InsertionSort.sort(numbers);
        System.out.println(Arrays.toString(result));
    }

}