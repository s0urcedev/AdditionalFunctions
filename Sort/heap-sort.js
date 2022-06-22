function heapify(array, n, i){
    let largest = i;
    let l = 2 * i + 1;
    let r = 2 * i + 2;
    if(l < n && array[i] < array[l]){
        largest = l;
    }
    if(r < n && array[largest] < array[r]){
        largest = r;
    }
    if(largest != i){
        array[i] = array[i] + array[largest];
        array[largest] = array[i] - array[largest];
        array[i] = array[i] - array[largest];
        heapify(array, n, largest);
    }
}

function sort(array){
    for(let i = Math.floor(array.length / 2); i > -1; i --){
        heapify(array, array.length, i);
    }
    for(let j = array.length - 1; j > 0; j --){
        array[j] = array[j] + array[0];
        array[0] = array[j] - array[0];
        array[j] = array[j] - array[0];
        heapify(array, j, 0);
    }
}

let a = [5, 6, 2, 9, 1];

sort(a);

console.log(a);