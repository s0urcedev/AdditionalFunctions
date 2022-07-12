function binarySearch(arr, value){
    let first = 0;
    let last = arr.length - 1;
    let middle;
    while(first <= last){
        middle = Math.floor((first + last) / 2);
        if(value < arr[middle]){
            last = middle - 1;
        }
        else if(value > arr[middle]){
            first = middle + 1;
        }
        else{
            return middle;
        }
    }
    return -1;
}