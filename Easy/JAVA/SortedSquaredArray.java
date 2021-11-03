package JAVA;

import java.util.Arrays;

class SortedSquaredArray {
    // O(nlogn) time | O(n) space
    public static int[] sortedSquaredArray1(int[] array) {
        int[] sorted = new int[array.length];
        for (int i = 0; i < array.length; i++) {
            sorted[i] = (int) Math.pow(array[i], 2);
        }
        Arrays.sort(sorted);

        return sorted;
    }

    // O(n) time | O(n) space
    public static int[] sortedSquaredArray2(int[] array) {
        int[] sorted = new int[array.length];
        int start = 0;
        int end = array.length - 1;
        for (int i = array.length - 1; i >= 0; i--) {
            if (array[start] < array[end]) {
                sorted[i] = (int) Math.pow(array[end], 2);
                end--;
            } else {
                sorted[i] = (int) Math.pow(array[start], 2);
                start++;
            }
        }

        return sorted;
    }

    public static void main(String[] args) {
        int[] array = new int[] { 1, 2, 3, 5, 6, 8, 9 };
        int[] result = sortedSquaredArray2(array);
        System.out.println(Arrays.toString(result));
    }
}