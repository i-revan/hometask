let num = 2379;
let digit1 = num % 10; // 3
let new_num = (num - digit1) / 10; // 258
let digit2 = new_num % 10; // 8
let new_num1 = (new_num - digit2) / 10; // 25
let digit3 = new_num1 % 10; // 5
let digit4 = (new_num1 - digit3) / 10; // 2
let reversed_number = digit1 * 1000 + digit2 * 100 + digit3 * 10 + digit4;
console.log(reversed_number);
