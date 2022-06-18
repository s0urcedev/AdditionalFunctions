function additionBigNumbers(a, b){
    a = String(a).split("").reverse().join("");
    b = String(b).split("").reverse().join("");

    while(b.length < a.length){
        b += '0';
    }
    while(a.length < b.length){
        a += '0';
    }

    let result = '';
    let c = 0;
    for(let i = 0; i < a.length; i ++){
        let localResult = Number(a[i]) + Number(b[i]) + c;
        c = 0;
        if(localResult > 9){
            localResult -= 10;
            c = 1;
        }
        result += String(localResult);
    }
    if(c == 1){
        result += '1';
    }
    return result.split("").reverse().join("");
}

function subtractionBigNumbers(a, b){
    let k = false;
    if(Number(a) > Number(b)){
        a = String(a).split("").reverse().join("");
        b = String(b).split("").reverse().join("");
    }
    else{
        k = true;
        swap = String(a).split("").reverse().join("");
        a = String(b).split("").reverse().join("");
        b = swap;
    }

    while(b.length < a.length){
        b += '0';
    }
    while(a.length < b.length){
        a += '0';
    }

    let result = '';
    let c = 0;
    for(let i = 0; i < a.length; i ++){
        let localResult = Number(a[i]) - Number(b[i]) - c;
        c = 0;
        if(localResult < 0){
            localResult += 10;
            c = 1;
        }
        result += String(localResult);
    }
    if(k){
        result += '-'
    }
    while(result[result.length - 1] == '0'){
        result = result.slice(0, result.length - 1);
    }
    return result.split("").reverse().join("");
}

function multiplicationBigNumbers(a, b){
    a = String(a).split("").reverse().join("");
    b = String(b).split("").reverse().join("");

    let result = '';
    let c = 0;
    for(let i = 0; i < b.length; i ++){
        let localResult = '';
        c = 0;
        for(let j = 0; j < a.length; j ++){
            let localLocalResult = Number(a[j]) * Number(b[i]) + c;
            c = 0;
            while(localLocalResult > 9){
                localLocalResult -= 10;
                c += 1
            }
            localResult += String(localLocalResult);
        }
        if(c > 0){
            localResult += String(c);
            c = 0;
        }
        let flocalResult = String(localResult).split("").reverse().join("");
        for(let f = 0; f < i; f ++){
            flocalResult += '0';
        }
        result = additionBigNumbers(String(result), String(flocalResult));
    }
    return result;
}