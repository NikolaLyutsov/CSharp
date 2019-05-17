function solve(args) {
    'use strict';
let heights = args[0].split(' ').map(Number);
let bestCount = -1;
let count = 0;
let current;
let isDescending = true;
current = heights[0];
heights.push(-1);
for(let i = 1; i < heights.length; i +=1) {
    let height = heights[i];
    if(isDescending){
        if(current < height){
            isDescending = !isDescending;
        }
    } else {
        if(current > height){
            bestCount = Math.max(bestCount, count);
            count = 0;
            isDescending = !isDescending;
        }
    }
    current = height;
    count+= 1;
}
console.log(bestCount);
}
solve([
    '5 1 7 4 8'
]);
solve([
    '5 1 7 6 3 6 4 2 3 8'
]);
solve([
    '10 1 2 3 4 5 4 3 2 1 10'
]);