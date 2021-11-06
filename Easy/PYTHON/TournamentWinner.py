def tournament_winner(competitions, results):
    scores = {}
    for i, competition in enumerate(competitions):
        result = results[i]
        homeTeam, awayTeam = competition

        winner = homeTeam if (result == 1) else awayTeam

        # scores[winner] = 3 if winner not in scores else scores[winner] = scores[winner] + 3

        if winner not in scores:
            scores[winner] = 3
        else:
            scores[winner] += 3

    return max(scores, key=lambda k: scores[k])


competitions = [
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
]

results = [0, 1, 1, 1, 0, 1, 0, 1, 1, 0]
result = tournament_winner(competitions, results)
print(result)
