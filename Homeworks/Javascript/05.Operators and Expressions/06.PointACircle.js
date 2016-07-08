function name(args) {
  var x = args[0];
  var y = args[1];

  var distance = Math.sqrt((x-0)*(x-0)+(y-0)*(y-0)).toFixed(2);
  if (distance <= 2) {
    console.log("yes " + distance);
  }
  else{
    console.log("no " + distance);
  }
}
name([-2, 0]);
