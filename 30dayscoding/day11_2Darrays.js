'use strict';

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', function(inputStdin) {
    inputString += inputStdin;
});

process.stdin.on('end', function() {
    inputString = inputString.split('\n');

    main();
});

function readLine() {
    return inputString[currentLine++];
}



function main() {

    let arr = Array(6);

    for (let i = 0; i < 6; i++) {
        arr[i] = readLine().replace(/\s+$/g, '').split(' ').map(arrTemp => parseInt(arrTemp, 10));
    }
    var max = 0;
    for (var i = 0; i < arr.length-2; i++){
        for (var j = 0; j < arr.length-2; j++){
            var sum = 0;
            //console.log(arr[i][j] +' '+ arr[i][j+1] +' '+ arr[i][j+2]) ver 3 de arriba
            //console.log(arr[i+1][j+1]) ver el del medio
            //console.log(arr[i+2][j] +' '+ arr[i+2][j+1] +' '+ arr[i+2][j+2]); ver 3 de abajo
            sum += arr[i][j] + arr[i][j+1] + arr[i][j+2]; //3 de arriba
            sum += arr[i+1][j+1]; // sumar el del medio
            sum += arr[i+2][j] + arr[i+2][j+1] + arr[i+2][j+2]; //3 de abajo
            if (sum > max || i == 0 && j == 0) max = sum;
            sum = 0;
        }
    }
    console.log(max);
}