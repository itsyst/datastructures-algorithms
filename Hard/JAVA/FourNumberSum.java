import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class FourNumberSum {

    public static List<int[]> fourNumberSums(int[] array, int targetSum) {
        // Create a dictionary to store pairs and their sums
        Map<Integer, List<int[]>> pairSums = new HashMap<>();
        List<int[]> quadruplets = new ArrayList<>();

        // Loop through the array, starting from the second element
        for (int i = 1; i < array.length - 1; i++) {
            // Loop through the elements after the current element to find pairs that sum to the target
            for (int j = i + 1; j < array.length; j++) {
                int currentSum = array[i] + array[j];
                int difference = targetSum - currentSum;

                // Check if the difference is in the dictionary, meaning a quadruplet is found
                if (pairSums.containsKey(difference)) {
                    // Add the found quadruplet to the list
                    for (int[] pair : pairSums.get(difference)) {
                        int[] newQuadruplet = { pair[0], pair[1], array[i], array[j] };
                        quadruplets.add(newQuadruplet);
                    }
                }
            }

            // Loop through the elements before the current element to find pairs
            for (int k = 0; k < i; k++) {
                int currentSum = array[i] + array[k];

                // If the pair sum is not in the dictionary, add a new list of pairs
                if (!pairSums.containsKey(currentSum)) {
                    pairSums.put(currentSum, new ArrayList<>());
                }

                // Add the pair to the dictionary
                int[] newPair = { array[k], array[i] };
                pairSums.get(currentSum).add(newPair);
            }
        }

        return quadruplets;
    }
}
