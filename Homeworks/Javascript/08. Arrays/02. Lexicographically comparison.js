function Solve(args){
  var word = args[0].split('\n');
var  inputOne = word[0];
var  inputTwo = word[1];
  if (inputOne === inputTwo) {
    console.log("=");
  }
  else if (inputOne < inputTwo){
    console.log("<");
  }
  else {
    console.log(">");
  }
}
Solve(['hello', 'halo']);
