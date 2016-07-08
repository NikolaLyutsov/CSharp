function PrimeCheck(args){
var n = args[0];
var isPrime = true;
if (n < 0) {
  console.log(false);
}
else{
  for (var i = 2; i <= n/2; i++) {
    if (n % i === 0) {
      isPrime = false;
      break;
    }
  }
  console.log(isPrime);
}
}
PrimeCheck([1]);
