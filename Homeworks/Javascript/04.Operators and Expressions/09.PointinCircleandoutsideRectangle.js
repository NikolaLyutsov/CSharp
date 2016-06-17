function solve(args) {
    var x = parseFloat(args[0]);
    var y = parseFloat(args[1]);
    var xC = 1;
    var yC = 1;
    var radius = 1.5;
    var xRmin = -1;
    var xRmax = 5;
    var yRmax = 1;
    var yRmin = -1;
    var isInRectangle;
    var isInCircle;
    if (x <= xRmax && x >= xRmin && y <= yRmax && y >= yRmin) {
        isInRectangle = "inside";
    } else {
        isInRectangle = "outside";
    }
    if ((x - xC) * (x - xC) + (y - yC) * (y - yC) <= radius * radius) {
        isInCircle = "inside";
    } else {
        isInCircle = "outside";
    }
    console.log(isInCircle + " circle " + isInRectangle + " rectangle");
}
solve([2.5, 2]);
