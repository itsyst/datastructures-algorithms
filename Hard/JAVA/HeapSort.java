public class HeapSort {
    public static int[] heapSort(int[] array) {
        int n = array.length;

        // Build the max-heap
        for (int i = n / 2 - 1; i >= 0; i--) {
            heapify(array, n, i);
        }

        // Extract elements from the heap
        for (int i = n - 1; i > 0; i--) {
            // Swap the current root with the end element
            swap(array, 0, i);

            // Heapify the reduced heap
            heapify(array, i, 0);
        }

        return array;
    }

    // Utility function to perform heapify operation
    private static void heapify(int[] array, int n, int i) {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        if (left < n && array[left] > array[largest]) {
            largest = left;
        }

        if (right < n && array[right] > array[largest]) {
            largest = right;
        }

        if (largest != i) {
            swap(array, i, largest);
            heapify(array, n, largest);
        }
    }

    // Utility function to swap elements in the array
    private static void swap(int[] array, int i, int j) {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    public static void main(String[] args) {
        int[] array = {12, 11, 13, 5, 6, 7};
        heapSort(array);
        for (int i = 0; i < array.length; i++) {
            System.out.print(array[i] + " ");
        }
    }
}
