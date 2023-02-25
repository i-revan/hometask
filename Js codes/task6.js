let num = 999;
let count = 0;
if(num >= 1){
    count += 1;
    num /= 10;
}
if(num >= 1){
    count += 1;
    num /= 10
}
if(num >= 1){
    count += 1;
    num /= 10
}
if(num >= 1){
    count += 1;
    num /= 10
}
if(count == 3){
    console.log("The number has 3 digits");
}
else{
    console.log("The number has no 3 digits");
}