let num = 4221;
let new_num = num;
let count = 0;
if (new_num >= 1) {
  count += 1;
  new_num /= 10;
}
if (new_num >= 1) {
  count += 1;
  new_num /= 10;
}
if (new_num >= 1) {
  count += 1;
  new_num /= 10;
}
if (new_num >= 1) {
  count += 1;
  new_num /= 10;
}
if (new_num >= 1) {
  count += 1;
  new_num /= 10;
}
if (count == 4 && num % 3 == 0 && num % 7 == 0) {
  console.log(true);
} else {
  console.log(false);
}
