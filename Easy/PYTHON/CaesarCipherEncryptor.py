
ENGLISH_ALPHABET = 26


def encrypt(str, key):
    output = ""

    for i in range(0, len(str)):
        if str[i].islower():
            ascii = (ord(str[i]) - ord('a') +
                     key) % ENGLISH_ALPHABET + ord('a')
            output += chr(ascii)
        else:
            ascii = (ord(str[i]) - ord('A') +
                     key) % ENGLISH_ALPHABET + ord('A')
            output += chr(ascii)

    return output


str = "ASBZ"
key = 1
result = encrypt(str, key)
print(result)
