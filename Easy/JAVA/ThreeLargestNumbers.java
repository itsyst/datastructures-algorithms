import java.util.Arrays;

public class ThreeLargestNumbers {
    public static final int CAPACITY = 3;

    public static int[] findLargestNumbers(int[] array) {
        Arrays.sort(array);
        int[] subArray = new int[CAPACITY];
        int j = 0;
        for (int i = 0; i < array.length; i++)
            if (i >= array.length - CAPACITY)
                subArray[j++] = array[i];

        return subArray;
    }

    public static int[] findThreeLargestNumbers(int[] array) {
        int[] numbers = new int[] { Integer.MIN_VALUE, Integer.MIN_VALUE, Integer.MIN_VALUE };
        for (var number : array)
            validate(numbers, number);

        return numbers;
    }

    public static void validate(int[] array, int number) {
        if (number > array[2])
            update(array, number, 2);
        else if (number > array[1])
            update(array, number, 1);
        else if (number > array[0])
            update(array, number, 0);
    }
    
    public static void update(int[] array, int number, int index) {
        for (int i = 0; i <= index; i++) 
            if( i == index )
                array[i] = number;
            else    
                array[i] = array[i + 1];

    }

    public static void main(String[] args) {
        int[] numbers = new int[] { 141, 1, 17, -7, -17, -27, 18, 541, 8, 7, 7 };
        // int[] result = ThreeLargestNumbers.findLargestNumbers(numbers);
        int[] result = ThreeLargestNumbers.findThreeLargestNumbers(numbers);
        System.out.println(Arrays.toString(result));
    }
}
