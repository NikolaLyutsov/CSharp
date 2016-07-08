function solve(args) {
    var str = args[0];
    var newname = str.replace(/ /g, "&nbsp;");
    console.log(newname);
}
solve([ 'hello world' ]);