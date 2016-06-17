function Trapezoids(args){
  var a = parseFloat(args[0]);
  var b = parseFloat(args[1]);
  var h = parseFloat(args[2]);
  var area = ((a+b)/2)*h;
  console.log(parseFloat(area).toFixed(7));
}
Trapezoids([2, 1, 33]);
