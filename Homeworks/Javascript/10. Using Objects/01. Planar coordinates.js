function solve(args) {
    var coordinates =  args.map(Number),
    lengths = [],
    a,
    b,
    i,
    output = 'Triangle can be built';

    function LineSize(x1, y1, x2, y2) {
        a = Math.abs(x1 - x2);
        b = Math.abs(y1 - y2);

        return Math.sqrt(a * a + b * b);
    }

    for(i = 0; i < 12; i += 4) {
        lengths[i / 4] = LineSize(coordinates[i], coordinates[i + 1], coordinates[i + 2], coordinates[i + 3]);
    }

    if(lengths[0] + lengths[1] < lengths[2] || lengths[2] + lengths[1] < lengths[0] || lengths[0] + lengths[2] < lengths[1]){
        output = 'Triangle can not be built';
    }

    for(i = 0; i < 3; i += 1) {
        console.log(parseFloat(Math.round(lengths[i] * 100) / 100).toFixed(2));
    }
    console.log(output);
}

solve(['5', '6', '7', '8', '1', '2', '3', '4', '9', '10', '11', '12']);
