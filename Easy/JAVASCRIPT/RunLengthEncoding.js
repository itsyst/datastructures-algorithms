const runEncoding = (str) => {
    let output = "";
    let count = 1;

    for (let i = 1; i < str.length; i++) {
        if (str[i] != str[i - 1] || count == 9) {
            output += count;
            output += str[i - 1];
            count = 0;
        }
        count++;
    }

    output += count;
    output += str[str.length - 1];

    return output;
}


const str = "AAAAAAAAAAAAABBCCCCDD";
const result = runEncoding(str);
console.log(result);