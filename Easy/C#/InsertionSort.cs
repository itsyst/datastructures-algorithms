class InsertionSort
{
    // O(n^2) time where n is the length of array | O(1) space
    public static int[] Sort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            int current = array[i];
            int j = i - 1;  
            while(j >=0 && array[j] > current){
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = current;
        }
        return array;
    }
}