using System.Collections.Generic;

class TournamentWinner
{
    // O(n) time | O(m) space where n is the number of competitions 
    // and m is the number of teams
    public static string TournamentWinner1(List<List<string>> competitions, List<int> results)
    {
        string currentWinner= "";
        Dictionary<string, int> scores = new Dictionary<string, int>();
        for (int i = 0; i < competitions.Count; i++)
        {
            List<string> competion = competitions[i];
            int result = results[i];

            string homeTeam = competion[0];
            string awayTeam = competion[1];

            string winner = (result == 1) ? homeTeam : awayTeam;
            if (!scores.ContainsKey(winner))
                scores.Add(winner, 0);

            scores[winner] += 3;
        }

        currentWinner = getMaxKey(scores);

        return currentWinner;
    }

    private static string getMaxKey(Dictionary<string, int> items){
        int maxValue = 0;
        string maxKey = "";
        foreach (var item in items)
        {
            if (item.Value > maxValue) {
                maxValue = item.Value;
                maxKey = item.Key;
            }
        }
        return maxKey;
    }
}
