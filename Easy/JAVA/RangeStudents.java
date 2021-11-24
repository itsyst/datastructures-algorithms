import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.List;

/**
 * RangeStudents
 */
public class RangeStudents {

    public static Boolean RowRange(List<Integer> redShirtStudents, List<Integer> blueShirtStudents) {
        Collections.sort(redShirtStudents, Collections.reverseOrder());
        Collections.sort(blueShirtStudents, Collections.reverseOrder());

        for (int i = 0; i < redShirtStudents.size(); i++) {
            if (redShirtStudents.get(0) > blueShirtStudents.get(0)) {
                if (redShirtStudents.get(i) <= blueShirtStudents.get(i)) {
                    return false;
                }
            } else {
                if (redShirtStudents.get(i) >= blueShirtStudents.get(i)) {
                    return false;
                }
            }
        }

        return true;
    }

    public static void main(String[] args) {
        List<Integer> redRow = new ArrayList<Integer>(Arrays.asList(19, 19, 21, 1, 1, 1, 1, 1));
        List<Integer> blueRow = new ArrayList<Integer>(Arrays.asList(20, 5, 4, 4, 4, 4, 4, 4));
        var result = RangeStudents.RowRange(redRow, blueRow);
        System.out.print(result);
    }
}