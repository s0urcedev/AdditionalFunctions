function sort(array, b, e){
    let l = b;
    let r = e;
    let p = array[Math.floor((l + r) / 2)];
    while(l <= r){
        while(array[l] < p){
            l ++;
        }
        while(array[r] > p){
            r --;
        }
        if(l <= r){
            if(l < r){
                array[l] = array[l] + array[r];
                array[r] = array[l] - array[r];
                array[l] = array[l] - array[r];
            }
            l ++;
            r --;
        }
        if(b < r){
            sort(array, b, r);
        }
        if(e > l){
            sort(array, l, e);
        }
    }
}

let a = [];

sort(a, 0, a.length - 1)

console.log(a);