function solve(args){
  var input = args[0].split(' '),
  numOne = +input[0],
  numTwo = +input[1],
  numThree = +input[2];
if (numThree > getMax(numOne, numTwo)) {
return numThree;
}
else{
  return getMax(numOne, numTwo);
}
  function getMax(first, second){
    if (first > second) {
      return first;
    }
    else{
      return second;
    }
  }
}
