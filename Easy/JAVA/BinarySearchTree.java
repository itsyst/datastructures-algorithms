/**
 * BinarySearchTree
 */
public class BinarySearchTree {
    public static int binarySearch(int[] array, int target) {
        return binarySearch(array, target, 0, array.length - 1);
    }

    // O(log(n)) time | O(log(n)) space
    private static int binarySearch(int[] array, int target, int left, int right) {
        if (left > right)
            return -1;

        int middle = (left + right) / 2;

        if (target == array[middle])
            return middle;

        if (target < array[middle])
            return binarySearch(array, target, left, middle - 1);

        return binarySearch(array, target, middle + 1, right);
    }

    public static void main(String[] args) {
        int[] array = new int[] { 0, 1, 21, 33, 45, 45, 61, 71, 72, 73 };
        var result = BinarySearchTree.binarySearch(array, 33);
        System.out.println(result);
    }
}