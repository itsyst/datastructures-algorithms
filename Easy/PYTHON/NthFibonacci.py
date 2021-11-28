def get_nth_fibonacci(n):
    if n <= 1:
        return 0
    elif n ==2:
        return 1
    else:
        return get_nth_fibonacci(n-1) + get_nth_fibonacci(n-2)


result = get_nth_fibonacci(6)
print(result)
