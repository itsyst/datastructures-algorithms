def is_palindrome_1(str):
    if str is None:
        return False

    input = ""
    for i in range(len(str)-1, -1, -1):
        input += str[i]

    return str == input


#  O(n) time | O(n) space
def is_palindrome_2(str):
    reversed = str[::-1]
    return reversed == str

# O(n) time | O(n) space


def is_palindrome_3(str):
    input = []

    for i in range(len(str)-1, -1, -1):
        input.append(str[i])

    return str == ''.join(input)

# O(n) time | O(n) space


def is_palindrome_4(str):
    if (str is None):
        return False

    return is_palindrome_4_helper(str, 0)


def is_palindrome_4_helper(str, i):
    j = len(str) - (1 + i)
    return True if (i >= j) else str[i] == str[j] and is_palindrome_4_helper(str, i + 1)


# O(n) time | O(1) space
def is_palindrome_5(str):
    if (str is None):
        return False

    left = 0
    right = len(str) - 1

    while (left < right):
        if str[left] != str[right]:
            return False
        left += 1
        right -= 1

    return True


str = "1234321"
result = is_palindrome_4(str)
print(result)
