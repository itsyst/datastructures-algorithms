nonConstructibleChange = (coins) => {
    coins.sort((a, b) => a - b);
    let currentChangeCoin = 0;
    for (const coin of coins) {
        if (coin > currentChangeCoin + 1)
            return currentChangeCoin + 1;
    
        currentChangeCoin += coin;
    }

    return currentChangeCoin + 1;
}



const result = nonConstructibleChange([1, 30, 4, 21, 100000]);
console.log(result);