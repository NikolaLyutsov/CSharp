function Solve(args){
  var a = +args[0];
  var b = +args[1];
  var c = +args[2];
if (a >= b) {
  if (a >= c) {
    console.log(a);
  }
  else {
    console.log(c);
  }
}
else {
  if (b >= c) {
    console.log(b);
  }
  else {
    console.log(c);
  }
}
}
Solve([5.345, -2, -2]);
