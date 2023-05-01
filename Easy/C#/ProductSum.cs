using System.Collections.Generic;

class ProductSum
{
    public static int ProductSummation(List<object> array)
    {
        return ProductSummationHelper(1, array);
    }

    // O(n) n is the number of the total number of elements.
    // O(D) depth of special array in arrays.
    public static int ProductSummationHelper(int factor, List<object> array)
    {
        int sum = 0;
        foreach (object element in array)
        {
            if (element is IList<object>)
                sum += ProductSummationHelper(factor + 1, (List<object>)element);
            else
                sum += (int)element;
        }
        return sum * factor;
    }

}