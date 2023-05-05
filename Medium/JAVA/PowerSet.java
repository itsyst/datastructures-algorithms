import java.util.ArrayList;
import java.util.List;

public class PowerSet {
    public static List<List<Integer>> powerset(List<Integer> array) {
        return getPowerset(array, 0);
    }

    private static List<List<Integer>> getPowerset(List<Integer> array, int index) {
        if (index == array.size()) {
            List<List<Integer>> emptySet = new ArrayList<>();
            emptySet.add(new ArrayList<>());
            return emptySet;
        }

        int currentElement = array.get(index);
        List<List<Integer>> subsets = getPowerset(array, index + 1);
        int length = subsets.size();

        for (int i = 0; i < length; i++) {
            List<Integer> currentSubset = new ArrayList<>(subsets.get(i));
            currentSubset.add(currentElement);
            subsets.add(currentSubset);
        }

        return subsets;
    }

    public static void main(String[] args) {
        List<Integer> array = new ArrayList<>();
        array.add(1);
        array.add(2);
        array.add(3);
        List<List<Integer>> result = powerset(array);

        System.out.println("Powerset: ");
        for (List<Integer> subset : result) {
            System.out.print("[");
            for (int element : subset) {
                System.out.print(element + ", ");
            }
            System.out.println("]");
        }
    }
}
