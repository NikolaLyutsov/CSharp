function solve(args){
  var input = +args[0][parseInt(args[0].length - 1)];
return getDigitAsWord(input);

function getDigitAsWord(digit){
  switch (digit) {
    case 0:
      return 'zero';
      case 1:
      return 'one';
      case 2:
       return 'two';
     case 3:
       return 'three';
     case 4:
       return 'four';
     case 5:
       return 'five';
     case 6:
       return 'six';
     case 7:
       return 'seven';
     case 8:
       return 'eight';
     case 9:
       return 'nine';
  }
}
}
console.log(solve(['42']));
