const firstNonRepeatingCharacter3 = (str) => {
    let visited = {};
    const chars = [...str.toLowerCase()]

    for (const ch of chars) {
        const count = visited.hasOwnProperty(ch) ? visited[ch] : 0;
        visited[ch] = count + 1;
    }

    for (let j = 0; j < chars.length; j++) {
        if (visited[chars[j]] == 1)
            return j;
    }

    return -1;
}

const firstNonRepeatingCharacter2 = (str) => {
    let visited = new Map();
    const chars = [...str.toLowerCase()]

    for (const ch of chars) {
        const count = visited.has(ch) ? visited.get(ch) : 0;
        visited.set(ch, count + 1);
    }

    for (let j= 0; j < chars.length; j++) {
        if (visited.get(chars[j]) == 1)
            return j;
    }

    return -1;
}

// O(n^2) time | O(1) space where n is the length of the input string
const firstNonRepeatingCharacter1 = (str) => {
    for (let i = 0; i < str.length; i++) {
        let visited = false;
        for (let j = 0; j < str.length; j++)
            if (str[i] === str[j] && i != j)
                visited = true;

        if (!visited)
            return i;
    }

    return -1;
}


const str = "faad*^?Abcbb*?ebdf";
const result = firstNonRepeatingCharacter3(str);
console.log(result);
