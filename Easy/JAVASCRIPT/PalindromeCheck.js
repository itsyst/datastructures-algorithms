// O(n^2) time | O(n) space
function isPalindrome1(str) {
    if (str === null)
        return false;

    let input = "";

    for (let i = str.length - 1; i >= 0; i--)
        // input += str[i];
        input += str.charAt(i);

    return str === input;
}

// O(n) time | O(n) space
function isPalindrome2(str) {
    let reversed = str.split("").reverse().join("");
    return reversed === str ;
}

// O(n) time | O(n) space
function isPalindrome3(str) {
    let input = [];

    for (let i = str.length - 1; i >= 0; i--)
    input.push(str.charAt(i));

    return str === input.join('');
}

    // O(n) time | O(n) space
function isPalindrome4(str) {
    if (str == null)
        return false;

    return isPalindromeHelper(str, 0);
}

function isPalindromeHelper(str,i) {
    let j = str.length  - (1 + i);
    return i >= j ? true : str.charAt(i) == str.charAt(j) && isPalindromeHelper(str, i + 1);
}

// O(n) time | O(1) space
function isPalindrome5(str) {
    if (str == null)
        return false;

    var left = 0;
    var right = str.length - 1;

    while (left < right) {
        if (str.charAt(left++) != str.charAt(right--))
            return false;
    }
    return true;
}

const str = "1234321";
const result = isPalindrome3(str);
console.log(result);
