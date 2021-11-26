<?php

namespace Easy\PHP\TotalSpeedBicycle;

function totalSpeedBicycle(array $redTeam, array $blueTeam, int $fastest)
{
    sort($redTeam);
    sort($blueTeam);

    if ($fastest) {
        $blueTeam = array_reverse($blueTeam);
    }

    $totalSpeed = 0;
    for ($i = 0; $i < count($redTeam); $i++) {
        $totalSpeed += max($redTeam[$i], $blueTeam[$i]);
    }

    return $totalSpeed;
}

$redTeam = [3, 4, 4, 1, 1, 8, 9];
$blueTeam = [9, 8, 2, 2, 3, 5, 6];
$fastest = true;
$result = totalSpeedBicycle($redTeam, $blueTeam, $fastest);
print_r($result);
