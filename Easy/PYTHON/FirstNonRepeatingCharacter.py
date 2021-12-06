def first_non_repeating_character_3(str):
    visited = {}
    chars = [*str.lower()]

    for ch in chars:
        count = visited.get(ch) if ch in visited else 0
        visited.update({ch: count+1})

    for j in range(len(chars)):
        if visited.get(chars[j]) == 1:
            return j

    return -1

def first_non_repeating_character_2(str):
    visited = {}
    chars = [*str.lower()]

    for ch in chars:
        if ch in visited:
            count = visited.get(ch)
        else:
            count = 0

        visited[ch] = count + 1

    for j in range(len(chars)):
        if visited.get(chars[j]) == 1:
            return j

    return -1


# O(n ^ 2) time | O(1) space where n is the length of the input string
def first_non_repeating_character_1(str):
    for i in range(len((str))):
        visited = False
        for j in range(len(str)):
            if str[i] == str[j] and i != j:
                visited = True

        if not visited:
            return i

    return -1


str = "faad*^?Abcbb*?ebdf"
result = first_non_repeating_character_2(str)
print(result)
