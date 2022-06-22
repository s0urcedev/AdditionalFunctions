let a = [];

for(let j = 1; j < a.length; j ++){
    key = a[j];
    i = j - 1;
    while(i >= 0 && a[i] > key){
        a[i + 1] = a[i];
        i --;
    } 
    a[i + 1] = key;
}

console.log(a);