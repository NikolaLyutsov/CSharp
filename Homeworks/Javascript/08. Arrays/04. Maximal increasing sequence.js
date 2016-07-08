function solve(args){
  var input = args[0].split('\n'),
  n = +input[0],
  numbers = input.slice(1),
  current = +numbers[0],
  increase = 1,
  bestIncrease = 0;
for (var i = 0; i < n; i++) {
  if (current < +numbers[i+1]) {
    increase++;
  }
  else {
    if (increase > bestIncrease) {
      bestIncrease = increase;
    }
    increase =1;
  }
  current = numbers[i+1];
}
console.log(bestIncrease);
}
solve(['8', '7', '3', '2', '3', '4', '2', '2', '4']);
