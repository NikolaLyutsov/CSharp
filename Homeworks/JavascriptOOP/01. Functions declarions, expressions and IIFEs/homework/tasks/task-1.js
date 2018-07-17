/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

function sum() {
	return function(numbers) {
		if(numbers.some(x => Number.isNaN(Number(x)))){
			throw 'Something is not a number';
		}
		if(numbers.length === 0){
			return null;
		}
		return numbers.reduce((x, y) => x + (+y), 0);
	}
}

module.exports = sum;
