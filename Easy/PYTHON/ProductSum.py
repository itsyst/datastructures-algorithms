def product_sum(array):
    return product_sum_helper(1, array)


def product_sum_helper(factor, array):
    sum = 0
    for element in array:
        if isinstance(element, list):
            sum += product_sum_helper(factor + 1, element)
        else:
            sum += element
    
    return sum * factor


special = [5, 2, [7, -1], 3, [6, [-13, 8], 4]]
result = product_sum(special)
print(result)
