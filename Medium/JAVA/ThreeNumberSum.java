import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashSet;
import java.util.List;
import java.util.Set;

public class ThreeNumberSum {

    public static List<Integer[]> threeNumbersSum1(int[] array, int targetSum) {
        List<Integer[]> triples = new ArrayList<Integer[]>();
        Arrays.sort(array);

        for (int i = 0; i < array.length - 2; i++)
            for (int j = i + 1; j < array.length - 1; j++)
                for (int k = j + 1; k < array.length; k++) {
                    int currentSum = array[i] + array[j] + array[k];
                    if (currentSum == targetSum)
                        triples.add(new Integer[] { array[i], array[j], array[k] });
                }

        return triples;
    }

    public static List<Integer[]> threeNumbersSum2(int[] array, int targetSum) {
        List<Integer[]> triples = new ArrayList<Integer[]>();
        Arrays.sort(array);

        for (int i = 0; i < array.length - 2; i++) {
            int left = i + 1;
            int right = array.length - 1;
            while (left < right) {
                int currentSum = array[left] + array[i] + array[right];
                if (currentSum == targetSum) {
                    triples.add(new Integer[] { array[i], array[left], array[right] });
                    left++;
                    right--;
                } else if (currentSum < targetSum)
                    left++;
                else
                    right--;
            }
        }

        return triples;
    }

    public static List<Integer[]> threeNumbersSum3(int[] array, int targetSum) {
        List<Integer[]> triples = new ArrayList<Integer[]>();
        for (int i = 0; i < array.length - 2; i++)
        {
            // Find pair in sub array array[i+1..n-1]s
            // with targetSum equal to currentSum - array[i]
            HashSet<Integer> set = new HashSet<>();
            int currentSum = targetSum - array[i];
            for (int j = i + 1; j < array.length; j++)
            {
                if (set.contains(currentSum - array[j]))
                    triples.add(new Integer[] { array[i], currentSum - array[j], array[j] });

                set.add(array[j]);
            }
        }

        return triples;
    }

    public static void main(String[] args) {
        int[] array = new int[] { 12, 3, 1, 2, -6, 5, -8, 6 };
        int target = 0;
        List<Integer[]> result = ThreeNumberSum.threeNumbersSum3(array, target);
        var listToArray = result.toArray();
        System.out.println(Arrays.deepToString(listToArray));
    }
}