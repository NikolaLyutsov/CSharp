function solve(endNumber) {
	result = '';
	for (var i = 1; i <= endNumber; i += 1)
  {
		result += i + ' ';
	}
	return result.trim();
}
console.log(solve(5));
