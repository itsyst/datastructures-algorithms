class RangeStudents
{
    public static Boolean RowRange(List<int> redRow, List<int> blueRow)
    {
        redRow.Sort((a, b) => b.CompareTo(a));
        blueRow.Sort((a, b) => b.CompareTo(a));


        for (int i = 0; i < redRow.Count; i++)
        {
            if (redRow[0] > blueRow[0])
            {
                if (redRow[i] <= blueRow[i])
                    return false;
            }
            else
            {
                if (redRow[i] >= blueRow[i])
                    return false;
            }
        }


        return true;
    }
}