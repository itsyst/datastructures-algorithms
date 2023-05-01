using System;

public class BestSeat
{

    public int BestSeats(int[] seats)
    {
        int bestSeat = -1;
        int maxSpace = 0;

        int left = 0;
        while (left < seats.Length)
        {
            int right = left + 1;
            while (right < seats.Length && seats[right] == 0)
            {
                right++;
            }

            int availableSpace = right - left - 1;
            if (availableSpace > maxSpace)
            {
                bestSeat = (left + right) / 2;
                maxSpace = availableSpace;
            }
            left = right;
        }

        return bestSeat;
    }
}
