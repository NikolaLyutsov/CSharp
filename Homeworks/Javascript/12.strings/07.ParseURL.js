function solve(args) {
    input = args[0] + '';
    var splited = input.split('/'),
        sl;
    splited[0] = splited[0].substring(0, splited[0].length - 1);
    console.log('protocol: ' + splited[0]);
    console.log('server: ' + splited[2]);
    sl = splited.slice(3);
    console.log('resource: /' + sl.join('/'));
}
solve([ 'http://telerikacademy.com/Courses/Courses/Details/239' ]);
