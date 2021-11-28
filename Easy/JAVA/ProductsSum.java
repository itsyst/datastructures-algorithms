import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

/**
 * ProductSum
 */
public class ProductsSum {

    public static Integer productSum(List<Object> array) {
        return productSumHelper(1, array);
    }

    private static Integer productSumHelper(Integer factor, List<Object> array) {
        Integer sum = 0;
        for (Object element : array)
            if (element instanceof ArrayList)
                sum += productSumHelper(factor + 1, (List<Object>) element);
            else
                sum += (Integer) element;

        return sum * factor;
    }

    public static void main(String[] args) {
        List<Object> numbers = new ArrayList<Object>(Arrays.asList(
                5, 2,
                new ArrayList<Object>(Arrays.asList(7, -1)),
                3,
                new ArrayList<Object>(Arrays.asList(6, new ArrayList<Object>(Arrays.asList(-13, 8)), 4))));
        Integer result = ProductsSum.productSum(numbers);
        System.out.println("Sum: " + result);
    }
}