let num = 236;
let digit1 = num % 10; //6
let new_num = (num - digit1) / 10; //23
let digit2 = new_num % 10; //3
let digit3 = (new_num - digit2) / 10;
let sum_of_digits = digit1 + digit2 + digit3;
console.log(sum_of_digits);