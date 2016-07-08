function solve(args){
  var input = args[0].split('\n'),
  n = +input[0],
  numbers = input.slice(1),
  current = +numbers[0];

  for (var i = 0; i < n; i++) {
    current = numbers[i];
    for (var j = i; j < n; j++) {
      if (+numbers[j] < current) {
        current = +numbers[j];
        numbers[j] = +numbers[i];
        numbers[i] = current;
      }
    }
  }
  console.log(numbers.join('\n'));
}
solve(['6', '3', '4', '1', '5', '2', '6']);
