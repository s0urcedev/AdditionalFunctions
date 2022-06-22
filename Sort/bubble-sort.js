let a = [];

let k = 0;
while(k < a.length - 1){
    k = 0;
    for(let j = 0; j < a.length - 1; j ++){
        if(a[j] > a[j + 1]){
            a[j] = a[j] + a[j + 1];
            a[j+1] = a[j] - a[j + 1];
            a[j] = a[j] - a[j + 1];
        }
        else{
            k ++;
        }
    }
}

console.log(a)