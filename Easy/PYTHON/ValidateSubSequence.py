# O(n) | O(1) space

def validate_subsequence1(array, sequence):
    array_index = 0
    sequence_index = 0
    while array_index < len(array) and sequence_index < len(sequence):
        if array[array_index] == sequence[sequence_index]:
            sequence_index += 1

        array_index += 1

    return sequence_index == len(sequence)


def validate_subsequence2(array, sequence):
    sequence_index = 0
    for number in array:
        if sequence_index == len(sequence):
            break

        if sequence[sequence_index] == number:
            sequence_index += 1

    return sequence_index == len(sequence)


# Validate Sub Sequence
org = [5, 1, 22, 25, 6, -1, 8, 10]
sub = [1, 6, -1, 10]
#sequence = [6, -1, 10, 13]
result = validate_subsequence2(array=org, sequence=sub)
print(result)
