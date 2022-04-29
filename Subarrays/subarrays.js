function maxSubarraySum(arr){
    let result = arr[0];
    let localResult = arr[0];
    for(let i = 1; i < arr.length; i ++){
        if(localResult > 0){
            localResult += arr[i];
        }
        else{
            localResult = arr[i];
        }
        if(localResult > result){
            result = localResult;
        }
    }
    return result;
}

function minSubarraySum(arr){
    let result = arr[0];
    let localResult = arr[0];
    for(let i = 1; i < arr.length; i ++){
        if(localResult < 0){
            localResult += arr[i];
        }
        else{
            localResult = arr[i];
        }
        if(localResult < result){
            result = localResult;
        }
    }
    return result;
}

function maxSubarrayProd(arr){
    let result = arr[0];
    let localResultPos = arr[0];
    let localResultNeg = arr[0];
    for(let i = 1; i < arr.length; i ++){
        let localResultMax, localResultMin;
        if(localResultPos * arr[i] > localResultNeg * arr[i]){
            localResultMax = localResultPos * arr[i];
            localResultMin = localResultNeg * arr[i];
        }
        else{
            localResultMax = localResultNeg * arr[i];
            localResultMin = localResultPos * arr[i];
        }
        if(arr[i] > localResultMax){
            localResultPos = arr[i];
        }
        else{
            localResultPos = localResultMax;
        }
        if(arr[i] < localResultMin){
            localResultNeg = arr[i];
        }
        else{
            localResultNeg = localResultMin;
        }
        if(localResultPos > result){
            result = localResultPos;
        }
    }
    return result;
}

function minSubarrayProd(arr){
    let result = arr[0];
    let localResultPos = arr[0];
    let localResultNeg = arr[0];
    for(let i = 1; i < arr.length; i ++){
        let localResultMax, localResultMin;
        if(localResultPos * arr[i] > localResultNeg * arr[i]){
            localResultMax = localResultPos * arr[i];
            localResultMin = localResultNeg * arr[i];
        }
        else{
            localResultMax = localResultNeg * arr[i];
            localResultMin = localResultPos * arr[i];
        }
        if(arr[i] > localResultMax){
            localResultPos = arr[i];
        }
        else{
            localResultPos = localResultMax;
        }
        if(arr[i] < localResultMin){
            localResultNeg = arr[i];
        }
        else{
            localResultNeg = localResultMin;
        }
        if(localResultNeg < result){
            result = localResultNeg;
        }
    }
    return result;
}

function maxCircularSubarraySum(arr){
    let maxElem = arr[0];
    let arrSum = 0;
    for(let i = 0; i < arr.length; i ++){
        if(arr[i] > maxElem){
            maxElem = arr[i];
        }
        arrSum += arr[i];
    }
    if(maxElem < 0){
        return maxElem;
    }
    let maxSimpleSum = maxSubarraySum(arr);
    let maxCircleSum = arrSum - minSubarraySum(arr);
    if(maxSimpleSum > maxCircleSum){
        return maxSimpleSum;
    }
    else{
        return maxCircleSum;
    }
}

function minCircularSubarraySum(arr){
    let minElem = arr[0];
    let arrSum = 0;
    for(let i = 0; i < arr.length; i ++){
        if(arr[i] < minElem){
            minElem = arr[i];
        }
        arrSum += arr[i];
    }
    if(minElem > 0){
        return minElem;
    }
    let minSimpleSum = minSubarraySum(arr);
    let minCircleSum = arrSum - maxSubarraySum(arr);
    if(minSimpleSum < minCircleSum){
        return minSimpleSum;
    }
    else{
        return minCircleSum;
    }
}