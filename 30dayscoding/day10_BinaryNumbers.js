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

///////SOLUTION/////////

function invertString(st) {
    return st.split("").reverse().join(""); 
    //convierte string en arreglo y lo invierte para obtener el binario correcto
}

function decimalToBinary(n, rod){
    var div = n;
    var res = 0;
    do{
        res = div % 2;
        rod += res.toString();
        div = Math.floor(div/2);
        if (div<2) rod += div.toString();
    }while(div>2);
    return rod;
}

function countOnes(rod){
    let count = 0;
    let max = 0;
    for (let j = 0; j<rod.length; j++){
        if(rod[j] == '1') count +=1;
        if (max < count) {
            max = count;
        }
        if (rod[j] == '0') count = 0;
    }
    return max;
}

function main() {
    const n = parseInt(readLine().trim(), 10);
    var rod = "";
    rod = decimalToBinary(n, rod);
    rod = invertString(rod);
    const final = countOnes(rod);
    console.log(final);
}