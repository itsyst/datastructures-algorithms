using System;

public class ArrayOfProducts
{
    public int[] ArrayOfProductss(int[] array)
    {
        int n = array.Length;
        int[] output = new int[n];

        // Calculate the product of all elements to the left of each index
        int leftProduct = 1;
        for (int i = 0; i < n; i++)
        {
            output[i] = leftProduct;
            leftProduct *= array[i];
        }

        // Multiply the product of all elements to the right of each index
        int rightProduct = 1;
        for (int i = n - 1; i >= 0; i--)
        {
            output[i] *= rightProduct;
            rightProduct *= array[i];
        }

        return output;
    }
}
