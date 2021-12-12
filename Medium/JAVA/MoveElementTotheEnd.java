import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

/**
 * MoveElementTotheEnd
 */
public class MoveElementTotheEnd {
    // O(n) time | O(1) space
    public static List<Integer> moveElementToEnd(List<Integer> array, int toMove) {
        int index = array.size() - 1;
        for (int i = array.size() - 1; i >= 0; i--)
            if (array.get(i) == toMove)
                swap(array, i, index--);

        return array;
    }

    private static void swap(List<Integer> array, int index1, int index2) {
        int temp = array.get(index1);
        array.set(index1, array.get(index2));
        array.set(index2, temp);
    }

    public static void main(String[] args) {
        List<Integer> array = new ArrayList<Integer>(Arrays.asList(2, 1, 2, 2, 2, 3, 4, 2));
        int toMove = 2;
        var result = MoveElementTotheEnd.moveElementToEnd(array, toMove);
        System.out.println(Arrays.toString(result.toArray()));
    }

}
