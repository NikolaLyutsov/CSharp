function solve(args) {
String.prototype.format = function(options) {
    var prop,
        result = this;
    for (prop in options) {
        result = result.replace(new RegExp('#{' + prop + '}', 'g'), options[prop]);
    }
    return result;
};

var options = JSON.parse(args[0]);
    result = args[1].format(options);

console.log(result);
}
solve([
'{ "name": "John" }',
"Hello, there! Are you #{name}?"
]);