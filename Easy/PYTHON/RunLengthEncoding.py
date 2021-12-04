def run_encoding(string):
    output = ""
    count = 1

    for i in range(1, len(string)):
        if string[i] != string[i - 1] or count == 9:
            output += str(count)
            output += string[i - 1]
            count = 0

        count += 1

    output += str(count) ## concact int to string
    output += string[len(string) - 1]

    return output


string = "AAAAAAAAAAAAABBCCCCDD"
result = run_encoding(string)
print(result)
