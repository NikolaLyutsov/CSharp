/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/
function findPrime(){
return function solve(num1, num2) {
    num1 = +num1;
    num2 = +num2;

    if(isNaN(num1) || isNaN(num2)){
        throw 'NOOO! Something is wrong!';
    }
    
    let primes = [];

    for(let i = num1; i <= num2; i+=1) {
        if(isPrime(i)){
            primes.push(i);
        }
    }
    return primes;

    function isPrime(number) {
		let maxDiv = Math.round(Math.sqrt(num2)); //round to int

		if (number < 2) {
			return false;
		}
		if (number === 2) {
			return true;
		}

		for (let i = 2; i <= maxDiv; i += 1) {
			if (number % i === 0) {
				return false;
			}
		}
		return true;
	}
}
}

module.exports = findPrime;
