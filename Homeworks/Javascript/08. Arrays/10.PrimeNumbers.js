function solve(args){
  var n = args[0],
  isPrime;

  for (var i = n; i >= 2; i-=1) {
    isPrime = true;
    for (var j = 2; j <= Math.sqrt(n); j++) {
      if (i % j === 0) {
        isPrime = false;
        break;
      }
    }
    if (isPrime === true) {
      return i;
    }
  }
  console.log(-1);
}
