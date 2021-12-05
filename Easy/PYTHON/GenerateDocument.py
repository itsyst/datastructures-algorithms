def generate_document2(characters, document):
    charsCount = {}

    for character in characters:
        if character not in charsCount:
            charsCount[character] = 0

        charsCount[character] += 1

    for character in document:
        if character not in charsCount or charsCount[character] == 0:
            return False

        charsCount[character] -= 1

    return True


def generate_document1(characters, document):
    for i in range(len(document)):
        documentCount = chars_frequency(document[i], document)
        charactersCount = chars_frequency(document[i], characters)

    if(documentCount > charactersCount):
        return False

    return True


def chars_frequency(char, toScan):
    count = 0
    for i in range(len(toScan)):
        if toScan[i] == char:
            count += 1

    return count


characters = "heeelloworlddd!"
document = "dllrow!oleh"
result = generate_document2(characters, document)
print(result)
