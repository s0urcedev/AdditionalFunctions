function sort(array, m){
    let mass = [];
    for(let i = 0; i < m; i ++){
        mass.push(array[i]);
    }
    if(m <= 1){
        array[0] = mass[0];
    }
    else{
        let l = [];
        let r = [];
        for(let i = 0; i < m; i ++){
            if(i < Math.floor(m/2)){
                l.push(mass[i]);
            }
            else{
                r.push(mass[i]);
            }
        }
        sort(l, l.length);
        sort(r, r.length);
        let h = 0;
        let f = 0;
        let c = [];
        while(h < l.length && f < r.length){
            if(l[h] < r[f]){
                c.push(l[h]);
                h += 1;
            }
            else{
                c.push(r[f]);
                f += 1;
            }
        }
        while(h < l.length){
            c.push(l[h]);
            h += 1;
        }
        while(f < r.length){
            c.push(r[f]);
            f += 1;
        }
        for(let i = 0; i < m; i++){
            array[i] = c[i];
        }
    }
}

let a = [];

sort(a, a.length);

console.log(a);