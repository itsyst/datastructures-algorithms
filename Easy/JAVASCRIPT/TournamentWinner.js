tournamentWinner = (competitions, results) => {
    let scores = new Map()
    let currentWinner = "";
    for (let i = 0; i < competitions.length; i++) {
        const competition = competitions[i];
        const homeTeam = competition[0];
        const awayTeam = competition[1];
        const result = results[i];

        let winner = (result === 1) ? homeTeam : awayTeam;

        if (!scores.has(winner))
            scores.set(winner, 0)
        scores.set(winner, scores.get(winner) + 3);

        const maxValue = getMaxValue(scores);     
        currentWinner = getMaxKey(scores, maxValue);
    }

    return currentWinner;


}

getMaxValue = (items = new Map(String, Number)) =>{
    return Math.max(...items.values());
}

getMaxKey = (items = new Map(String, Number), value) => {
    let maxKey = "";
    for (let item of items.entries())  
        if (item[1] === value)
            maxKey = item[0];
  
    return maxKey
}
  

const competitions = [
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
const results = [0, 1, 1, 1, 0, 1, 0, 1, 1, 0];

const result = tournamentWinner(competitions, results);
console.log("Winner: ", result);