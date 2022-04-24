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
    let max_elem = arr[0];
    let arr_sum = 0;
    for(let i = 0; i < arr.length; i ++){
        if(arr[i] > max_elem){
            max_elem = arr[i];
        }
        arr_sum += arr[i];
    }
    if(max_elem < 0){
        return max_elem;
    }
    let max_simple_sum = maxSubarraySum(arr);
    let max_cicle_sum = arr_sum - minSubarraySum(arr);
    if(max_simple_sum > max_cicle_sum){
        return max_simple_sum;
    }
    else{
        return max_cicle_sum;
    }
}

function minCircularSubarraySum(arr){
    let min_elem = arr[0];
    let arr_sum = 0;
    for(let i = 0; i < arr.length; i ++){
        if(arr[i] < min_elem){
            min_elem = arr[i];
        }
        arr_sum += arr[i];
    }
    if(min_elem > 0){
        return min_elem;
    }
    let min_simple_sum = minSubarraySum(arr);
    let min_cicle_sum = arr_sum - maxSubarraySum(arr);
    if(min_simple_sum < min_cicle_sum){
        return min_simple_sum;
    }
    else{
        return min_cicle_sum;
    }
}