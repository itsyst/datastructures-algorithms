<?php 

namespace Easy\PHP\GenerateDocument;

function generate_document2($characters, $document)
{
    $charsCount = [];
    $chars = str_split($characters);
    $docs = str_split($document);

    foreach ($chars as $character) {
        if (in_array($character, $charsCount)) {
            $charsCount[$character] = 0;
        }
        $charsCount[$character]++;
    }
    

    foreach ($docs as $character) {
        if (in_array($character, $charsCount) || $charsCount[$character] == 0) {
            return false;
        }
        $charsCount[$character]--;
    }
    return true;
}


function generate_document1($characters, $document) {
    for ($i=0; $i< strlen($document); $i++) {
        $documentCount = charsFrequency($document[$i], $document);
        $charactersCount = charsFrequency($document[$i], $characters);
    }

    if ($documentCount > $charactersCount) {
        return false;
    }

    return true;
}

function charsFrequency($char, $toScan)
{
    $count = 0;
    for ($i=0; $i<strlen($toScan); $i++) {
        if ($toScan[$i] == $char) {
            $count ++;
        }
    }

    return $count;
}


$characters = "heeelloworlddd!";
$document = "dll2row!oleh";
$result = generate_document2($characters, $document);

var_dump($result);





