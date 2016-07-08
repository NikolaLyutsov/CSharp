function Solve(args){
  var input = +args[0];
  var array = [];
for (var i = 0; i < input; i++)
{
  array[i] = +(i*5);
  console.log(array[i]);
}
}
Solve(['5']);
