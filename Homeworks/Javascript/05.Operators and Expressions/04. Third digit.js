function CheckThirdDigit(args) {
    var number = args[0];
    var thirdDigit = (((number % 1000) /100) | 0);
    if (thirdDigit === 7) {
      console.log('true');
    }
    else{
      console.log('false ' + thirdDigit);
    }
}
CheckThirdDigit([701]);
