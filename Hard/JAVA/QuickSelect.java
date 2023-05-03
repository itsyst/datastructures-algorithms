import java.util.Random;

public class QuickSelect {
    public static void main(String[] args) {
        int[] array = {12, 11, 13, 5, 6, 7};
        int k = 3;

        int kthSmallest = quickselect(array, k);
        System.out.println("The " + k + "th smallest element is: " + kthSmallest);
    }

    public static int quickselect(int[] array, int k) {
        return quickselect(array, 0, array.length - 1, k - 1);
    }

    private static int quickselect(int[] array, int left, int right, int k) {
        if (left == right) {
            return array[left];
        }

        Random random = new Random();
        int pivotIndex = random.nextInt(right - left + 1) + left;

        pivotIndex = partition(array, left, right, pivotIndex);

        if (k == pivotIndex) {
            return array[k];
        } else if (k < pivotIndex) {
            return quickselect(array, left, pivotIndex - 1, k);
        } else {
            return quickselect(array, pivotIndex + 1, right, k);
        }
    }

    private static int partition(int[] array, int left, int right, int pivotIndex) {
        int pivotValue = array[pivotIndex];
        swap(array, pivotIndex, right);

        int storeIndex = left;
        for (int i = left; i < right; i++) {
            if (array[i] < pivotValue) {
                swap(array, storeIndex, i);
                storeIndex++;
            }
        }

        swap(array, right, storeIndex);
        return storeIndex;
    }

    private static void swap(int[] array, int i, int j) {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}
