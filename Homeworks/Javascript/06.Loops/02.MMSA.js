function solve(args){
  var min = +args[0];
  var max = +args[0];
  var sum = 0;
  var avg = 0;
  var len = args.length;
for (var i = 0; i < len; i++) {
  var element = +args[i];
if (element <= min) {
 min = element;
}
  if (element >= max) {
    max = element;
  }
  sum += element;
  }
avg = sum/len;
console.log('min=' + min.toFixed(2));
console.log('max=' + max.toFixed(2));
console.log('sum=' + sum.toFixed(2));
console.log('avg=' + avg.toFixed(2));
}
solve([2, 5, 1]);
