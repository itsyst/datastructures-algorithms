
const ENGLISH_ALPHABET = 26;

const encrypt = (str, key) => {
    let output = "";

    for (let i = 0; i < str.length; i++) {
        let char = str[i];
        if (char == char.toLowerCase()) {
            let ascii = (str[i].charCodeAt(0) - 'a'.charCodeAt(0) + key) % ENGLISH_ALPHABET + 'a'.charCodeAt(0);
            output += String.fromCharCode(ascii);
        } else {
            let ascii = (str[i].charCodeAt(0) - 'A'.charCodeAt(0) + key) % ENGLISH_ALPHABET + 'A'.charCodeAt(0);
            output += String.fromCharCode(ascii);
        }
    }

    return output.toString();
}


const str = "ASBO";
const key = 10;
const result = encrypt(str, key);
console.log(result);


