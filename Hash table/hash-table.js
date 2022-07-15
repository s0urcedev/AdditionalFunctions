class HashTable{

    #size = 0;
    #table = [];

    #isPrime(n){
        let result = [];
        let d = 2;
        while(d * d <= n){
            if(n % d == 0){
                result.push(d);
                n = Math.floor(n / d);
            }
            else{
                d ++;
            }
        }
        if(n > 1){
            result.push(n);
        }
        if(result.length > 1) return false;
        else return true;
    }

    #nearestPrime(n){
        if(n % 2 == 0){
            n ++;
        }
        while(!this.#isPrime(n)){
            n += 2;
        }
        return n;
    }

    #countHash(s){
        let n = 7;
        for(let c of s){
            n = n * 31 + c.charCodeAt(0);
        }
        return Math.floor(this.#size * (n * ((Math.sqrt(5) - 1) / 2) % 1));
    }

    constructor(size){
        this.#size = this.#nearestPrime(size);
        this.#table = Array(this.#size).fill(undefined);
    }

    search(key){
        return this.#table[this.#countHash(key)];
    }

    insert(key, value){
        this.#table[this.#countHash(key)] = value;
    }

    remove(key){
        this.#table[this.#countHash(key)] = undefined;
    }
}