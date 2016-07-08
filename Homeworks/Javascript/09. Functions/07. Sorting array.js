function solve(args) {
  var n = +args[0],
  numbers = args[1].split(' ').map(Number);

  if (numbers.length > 1) {
         console.log(numbers.sort(function (x ,y)
         { return x - y;}
         ).join(' '));
     }
}
solve(['6\n3 4 1 5 2 6']);
