function solve(args){
  var arr = args[0].split('\n'),
  n = arr[0],
  numbers = arr.slice(1),
  current = numbers[0],
  sum = 1,
  bestNum = 0,
  best = 0;

numbers.sort();

  for (var i = 0; i < n; i++) {
    if (current === numbers[i+1]) {
      sum++;
    }
    else{
      if (sum > +best) {
        best = sum;
        bestNum = numbers[i];
      }
      sum = 1;
    }
    current = numbers[i + 1];
  }
  console.log(bestNum + " (" + best + " times)");
}
