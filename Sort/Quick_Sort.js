let a = [];

function sort(Mass, b, e){
    let l = b;
    let r = e;
    let p = Mass[Math.floor((l + r) / 2)];
    while(l <= r){
        while(Mass[l] < p){
            l ++;
        }
        while(Mass[r] > p){
            r --;
        }
        if(l <= r){
            if(l < r){
                Mass[l] = Mass[l] + Mass[r];
                Mass[r] = Mass[l] - Mass[r];
                Mass[l] = Mass[l] - Mass[r];
            }
            l ++;
            r --;
        }
        if(b < r){
            sort(Mass, b, r);
        }
        if(e > l){
            sort(Mass, l, e);
        }
    }
}

sort(a, 0, a.length - 1)

console.log(a);