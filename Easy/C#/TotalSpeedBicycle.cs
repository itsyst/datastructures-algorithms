using System;

class TotalSpeedBicycle
{
    public static int TandemBicycle(int[] redTeam, int[] blueTeam, bool fastest)
    {
        Array.Sort(redTeam);
        Array.Sort(blueTeam);

        if (fastest == true)
            Array.Reverse(blueTeam);

        int maxPairSpeed = 0;
        for (int i = 0; i < redTeam.Length; i++)
            maxPairSpeed += Math.Max(redTeam[i], blueTeam[i]);

        return maxPairSpeed;
    }

}