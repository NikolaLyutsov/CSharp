function solve(args){
  var input = args[0].split('\n'),
  n = +input[0],
  arr = input[1].split(' ');

  console.log(Larger(arr));

  function Larger(array){
    var i;
    for (i = 0; i < array.length - 1; i++) {
      if (+array[i] > +array[i + 1]) {
        return i;
      }
    }
    return -1;
  }
}
