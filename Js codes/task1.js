let num = 2332;
let digit1 = num % 10; // 2
let new_num = (num - digit1) / 10; // 233
let digit2 = new_num % 10; // 3
let new_num1 = (new_num - digit2) / 10; // 23
let digit3 = new_num1 % 10; // 3
let digit4 = (new_num1 - digit3) / 10;
if (digit1 == digit4 && digit2 == digit3) {
  console.log("YES");
} else {
  console.log("NO");
}
