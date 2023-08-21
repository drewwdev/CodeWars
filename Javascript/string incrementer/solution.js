// problem: https://www.codewars.com/kata/54a91a4883a7de5d7800009c/javascript

function incrementString(strng) {
  const lastChar = strng[strng.length - 1];

  if (!isNaN(lastChar)) {
    let numericPart = lastChar;
    let i = strng.length - 2;

    while (!isNaN(strng[i])) {
      numericPart = strng[i] + numericPart;
      i--;
    }

    const textPart = strng.substring(0, i + 1);
    const incrementedNumber = parseInt(numericPart) + 1;
    const paddedNumber = String(incrementedNumber).padStart(
      numericPart.length,
      "0"
    );

    return textPart + paddedNumber;
  } else {
    return strng + "1";
  }
}
