// O((n+m)) time | O(s) space
// n is number of characters and m is the length of the document.
const generateDocument2 = (characters, document) => {
    const charsCount = {};

    for (const character of characters) {
        if (!(character in charsCount))
            charsCount[character] = 0;
        
        charsCount[character]++;
    }

    for (const character of document) {
        if (!(character in charsCount) || charsCount[character] === 0)
            return false;

        charsCount[character]--;
    }

    return true;
}

// O(m*(n+m)) time | O(1) space
// n is number of characters and m is the length of the document.
const generateDocument1 = (characters, document) => {
    for (let i = 0; i < document.length; i++) {

        let documentCount = characterFrequency(document, document[i]);
        let charactersCount = characterFrequency(characters, document[i]);

        if (documentCount > charactersCount)
            return false;

    }

    return true;
}

const characterFrequency = (toScan, character) => {
    let count = 0;
    for (let i = 0; i < toScan.length; i++) {
        if (toScan[i] == character)
            count++;
    }
    return count;
}

const characters = "heeelloworlddd!";
const document = "dllrow!oleh";
const result = generateDocument3(characters, document);
console.log(result);