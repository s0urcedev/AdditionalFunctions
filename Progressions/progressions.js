class ArithmeticProgression{
    
    #d = 0;
    #a = [];
    
    constructor(start = 0, d = 0){
        this.#a.push(start);
        this.#d = d;
    }

    get sequence(){
        return this.#a;
    }

    get difference(){
        return this.#d;
    }

    set startElement(start){
        this.#a = [start];
    }

    set difference(d){
        this.#a = [this.#a[0]];
        this.#d = d;
    }

    getNth(n){
        return this.#a[0] + (n - 1) * this.#d;
    }

    countToNth(n){
        for(let _ = this.#a.length; _ < n; _ ++){
            this.#a.push(this.#a[this.#a.length - 1] + this.#d);
        }
    }

    getToNth(n){
        this.countToNth(n);
        return this.#a;
    }

    getSumToNth(n){
        return ~~(n * (this.#a[0] + this.getNth(n)) / 2);
    }
}

class GeometricProgression{
    
    #r = 1;
    #b = [];
    
    constructor(start = 1, r = 1){
        if(start == 0 || r == 0){
            console.log("startElement or ratio can't be 0");
            return; 
        }
        this.#b.push(start);
        this.#r = r;
    }

    get sequence(){
        return this.#b;
    }

    get ratio(){
        return this.#r;
    }

    set startElement(start){
        if(start == 0){
            console.log("startElement can't be 0");
            return; 
        }
        this.#b = [start];
    }

    set ratio(r){
        if(r == 0){
            console.log("ratio can't be 0");
            return; 
        }
        this.#b = [this.#b[0]];
        this.#r = r;
    }

    getNth(n){
        return this.#b[0] * (this.#r ** (n - 1));
    }

    countToNth(n){
        for(let _ = this.#b.length; _ < n; _ ++){
            this.#b.push(this.#b[this.#b.length - 1] * this.#r);
        }
    }

    getToNth(n){
        this.countToNth(n);
        return this.#b;
    }

    getSumToNth(n){
        if(this.#r == 1) return n * this.#b[0];
        return ~~((this.#b[0] * ((this.#r ** n) - 1)) / (this.#r - 1));
    }

    getProdToNth(n){
        return ~~((this.#b[0] * this.get_nth(n)) ** (n / 2));
    }
}

class HarmonicProgression{
    
    #d = 0;
    #c = [];
    
    constructor(start = 1, d = 0){
        this.#c.push(start);
        this.#d = d;
    }

    get sequence(){
        return this.#c;
    }

    get difference(){
        return this.#d;
    }

    set startElement(start){
        this.#c = [start];
    }

    set difference(d){
        this.#c = [this.#c[0]];
        this.#d = d;
    }

    getNth(n){
        return ((this.#c[0] ** -1) + (n - 1) * this.#d) ** -1;
    }

    countToNth(n){
        for(let _ = this.#c.length; _ < n; _ ++){
            this.#c.push(((this.#c[this.#c.length - 1] ** -1) + this.#d) ** -1);
        }
    }

    getToNth(n){
        this.countToNth(n);
        return this.#c;
    }
}