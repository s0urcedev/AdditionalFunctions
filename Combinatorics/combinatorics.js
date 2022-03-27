let comb = require('additional-functions/combinatorics');
let fact = require('additional-functions/factorials');

function generateCombinations(arr, k){
    let result = [];
    for(let i = 0; i < comb.countCombinations(arr.length, k); i ++){
        let localResult = [0];
        let n = arr.length;
        let s = 0;
        for(let j = 1; j <= k; j ++){
            let t = localResult[j - 1] + 1;
            while((t < (n - k + j)) && ((s + comb.countCombinations(n - t, k - j)) <= i)){
                s += comb.countCombinations(n - t, k - j);
                t ++;   
            }
            localResult.push(t);
        }
        for(l in localResult){
            localResult[l] = arr[localResult[l] - 1];
        }
        result.push(localResult.slice(1, localResult.length));
    }
    return result;
}

function generatePermutations(arr, k = NaN){
    if(isNaN(k)){
        k = arr.length;
    }
    let result = [];
    let m = generateCombinations(arr, k);
    for(arr of m){
        let localResult = [];
        for(let i = 0; i < fact.factorial(arr.length); i ++){
            let ind = i + 1;
            let localLocalResult = [];
            let localLocalArr = [];
            for(a of arr){
                localLocalArr.push(a);
            }
            let n = localLocalArr.length;
            for(let j = 1; j <= n; j ++){
                let f = fact.factorial(n - j);
                let g = Math.floor((ind + f - 1) / f);
                localLocalResult.push(localLocalArr.splice(g - 1, 1)[0]);
                ind -= (g - 1) * f;
            }
            if(localLocalArr.length){
                localLocalResult.push(localLocalArr[0]);
            }
            localResult.push(localLocalResult);
        }
        for(u of localResult){
            result.push(u);
        }
    }
    return result;
}