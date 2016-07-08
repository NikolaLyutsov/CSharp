function Solve(args){
  var a = args[0];
  var b = args[1];
  var c = args[2];
  var product = a*b*c;
  if (product > 0) {
    console.log("+");
  }
  else if (product < 0){
    console.log("-");
  }
  else{
    console.log(0);
  }
}
Solve([-2, -2, 1]);
