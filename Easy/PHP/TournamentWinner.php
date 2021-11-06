<?php

/**
 * Sort squared array.
 *
 * @param array[array] $competitions.
 *
 * @param array $results.
 *
 * @return string
 */
function tournamentWinner($competitions, $results)
{
    $scores = new \Ds\Map();
    $currentWinner = "";
    for ($x = 0; $x < count($competitions); $x++) {
        $competition = $competitions[$x];

        $homeTeam = $competition[0];
        $awayTeam = $competition[1];
        $result = $results[$x];

        $winner = ($result === 1) ? $homeTeam : $awayTeam;

        if ($scores->hasKey($winner)) {
            $value = $scores->get($winner) + 3;
            $scores->put($winner, $value);
        } else {
            $scores->put($winner, 0);
        }

        $currentWinner = getMaxKey($scores);
    }

    return  $currentWinner;
}


function getMaxKey($items)
{
    $array = $items->toArray();
    $maxValue = max($array);
 
    return array_search($maxValue, $array);
}

$competitions = [
    ["HTML", "Java"],
    ["Java", "Python"],
    ["Python", "HTML"],
    ["C#", "Python"],
    ["Java", "C#"],
    ["C#", "HTML"],
    ["SQL", "C#"],
    ["HTML", "SQL"],
    ["SQL", "Python"],
    ["SQL", "Java"]
];
$results = [0, 1, 1, 1, 0, 1, 0, 1, 1, 0];

$result = tournamentWinner($competitions, $results);
//var_dump($result);

print_r($result);
