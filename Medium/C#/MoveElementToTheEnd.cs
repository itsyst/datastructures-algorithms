class MoveElementToTheEnd
{
    // O(n) time | O(1) space
    public static List<int> MoveElementToEnd(List<int> array, int toMove)
    {
        int index = array.Count -1;
        for (int i = array.Count-1; i >=0; i--)
            if (array[i] == toMove)
                swap(array, i, index--);

        return array;
    }

    private static void swap(List<int> array, int index1, int index2)
    {
        int temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }

}