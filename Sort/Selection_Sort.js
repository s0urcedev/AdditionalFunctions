let a = [];

for(let i = 0; i < a.length - 1; i ++){
    let imin = i;
    for(let j = i + 1; j < a.length; j ++){
        if(a[j] < a[imin]){
            imin = j;
        }
    }
    if(imin != i){
        a[i] = a[i] + a[imin];
        a[imin] = a[i] - a[imin];
        a[i] = a[i] - a[imin];
    }
}

console.log(a);