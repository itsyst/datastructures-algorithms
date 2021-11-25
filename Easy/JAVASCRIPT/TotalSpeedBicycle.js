const totalSpeedBicycle = (redTeam, blueTeam, fastest) => {
    redTeam.sort((a, b) => (a - b));
    blueTeam.sort((a, b) => (a - b));

    if (fastest)
        blueTeam.reverse();
    
    let totalMaxSpeed = 0;
    for (let i = 0; i < blueTeam.length; i++)
        totalMaxSpeed += Math.max(redTeam[i], blueTeam[i]);

    return totalMaxSpeed;
}

const redTeam = [3, 4, 4, 1, 1, 8, 9];
const blueTeam = [9, 8, 2, 2, 3, 5, 6];
const fastest = true;
const result = totalSpeedBicycle(redTeam, blueTeam, fastest);
console.log(result);
