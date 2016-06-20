function solve(args){
  var input = +args[0];
  var result = '';
  for (var i = 0; i < input; i++) {
for (var j = i + 1; j <= input + i; j++) {
  result += j + ' ';
}
result += '\n';
}
return result;
}
console.log(solve([3]));
