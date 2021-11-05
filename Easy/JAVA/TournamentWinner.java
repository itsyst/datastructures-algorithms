import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.HashMap;

/**
 * TournamentWinner 
 * // O(n) time | O(m) space where n is the number of competitions 
 * // and m is the number of teams
 */
public class TournamentWinner {

    public static String tournamentWinner(ArrayList<ArrayList<String>> competitions, ArrayList<Integer> results) {

        String currentWinner = "";
        HashMap<String, Integer> scores = new HashMap<>();

        for (int i = 0; i < competitions.size(); i++) {
            ArrayList<String> competition = competitions.get(i);
            Integer result = results.get(i);

            String homeTeam = competition.get(0);
            String awayTeam = competition.get(1);

            String winner = (result == 1) ? homeTeam : awayTeam;
            updateScore(scores, winner);
        }

        currentWinner = getMaxValue(scores);
        return currentWinner;
    }

    private static String getMaxValue(HashMap<String, Integer> items) {
        Integer maxValue = Collections.max(items.values());
        String maxKey = "";
        for (var item : items.entrySet())
            if (item.getValue() == maxValue)
                maxKey = item.getKey();

        return maxKey;
    }

    private static void updateScore(HashMap<String, Integer> scores, String key) {
        if (!scores.containsKey(key))
            scores.put(key, 0);

        scores.put(key, scores.get(key) + 3);
    }

    public static void main(String[] args) {
        ArrayList<ArrayList<String>> competitions = new ArrayList<ArrayList<String>>();

        competitions.add(new ArrayList<String>(Arrays.asList("HTML", "Java")));
        competitions.add(new ArrayList<String>(Arrays.asList("Java", "Python")));
        competitions.add(new ArrayList<String>(Arrays.asList("Python", "HTML")));
        competitions.add(new ArrayList<String>(Arrays.asList("C#", "Python")));
        competitions.add(new ArrayList<String>(Arrays.asList("Java", "C#")));
        competitions.add(new ArrayList<String>(Arrays.asList("C#", "HTML")));
        competitions.add(new ArrayList<String>(Arrays.asList("SQL", "C#")));
        competitions.add(new ArrayList<String>(Arrays.asList("HTML", "SQL")));
        competitions.add(new ArrayList<String>(Arrays.asList("SQL", "Python")));
        competitions.add(new ArrayList<String>(Arrays.asList("SQL", "Java")));

        ArrayList<Integer> results = new ArrayList<Integer>(Arrays.asList(0, 1, 1, 1, 0, 1, 0, 1, 1, 0));

        String result = tournamentWinner(competitions, results);
        System.out.println("Winner:" + result);
    }

}