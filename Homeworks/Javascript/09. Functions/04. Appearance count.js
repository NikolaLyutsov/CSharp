function solve(args){
  var input = args[0].split('\n'),
  n = +input[0],
  numbers = input[1].split(' ').map(Number),
  search = +input[2],
  counter = 0;

  for (var i = 0; i < numbers.length; i++) {
if (numbers[i] === search) {
  counter+=1;
}
  }
  console.log(counter);
}
console.log(solve());
