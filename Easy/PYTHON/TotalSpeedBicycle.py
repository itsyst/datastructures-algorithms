def total_speed_bicycle(readTeam, blueTeam, fastest):
    readTeam.sort()
    blueTeam.sort()

    if fastest:
        blueTeam.sort(reverse=True)

    totalSpeed = 0
    for i in range(0, len(readTeam)):
        totalSpeed += max(readTeam[i], blueTeam[i])

    return totalSpeed


redTeam = [3, 4, 4, 1, 1, 8, 9]
blueTeam = [9, 8, 2, 2, 3, 5, 6]
fastest = True
result = total_speed_bicycle(redTeam, blueTeam, fastest)
print(result)
