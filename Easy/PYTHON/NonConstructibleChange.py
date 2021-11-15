
def non_constructible_change(coins):
    coins.sort()
    currentChangeCoin = 0
    for coin in coins:
        if coin > currentChangeCoin + 1:
            return currentChangeCoin + 1
        currentChangeCoin += coin

    return currentChangeCoin + 1


result = non_constructible_change([1, 5, 2])
print(result)
