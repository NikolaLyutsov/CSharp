function bit(dec) {
    var a = +dec[0];
var b = (a >>> 3).toString(2) + "";
console.log(b[b.length - 1]);
}
bit([15]);
