class Test{
    
    #function = null;
    #arguments = [];
    #results = [];

    constructor(){

    }

    set function(func){
        this.#function = func;
    }

    addTestCases(){
        for(let a of arguments){
            this.#arguments.push(a[0]);
            this.#results.push(a[1]);
        }
    }

    testAll(){
        for(let i = 0; i < this.#arguments.length; i ++){
            if(this.#function(...this.#arguments[i]) != this.#results[i]){
                return false;
            }
        }
        return true;
    }

    test(func, args, res){
        return func(...args) == res;
    }

    findValid(){
        let result = [];
        for(let i = 0; i < this.#arguments; i ++){
            try{
                if(this.#function(...this.#arguments[i]) == this.#results[i]){
                    result.push([[...this.#arguments[i]], this.#results[i]]);
                }
            }
            catch(err){

            }
        }
        return result;
    }

    findInvalid(){
        let result = [];
        for(let i = 0; i < this.#arguments; i ++){
            try{
                if(this.#function(...this.#arguments[i]) != this.#results[i]){
                    result.push([[...this.#arguments[i]], this.#results[i]]);
                }
            }
            catch(err){

            }
        }
        return result;
    }

    findFailed(){
        let result = [];
        for(let i = 0; i < this.#arguments; i ++){
            try{
                this.#function(...this.#arguments[i]);
            }
            catch(err){
                result.push([[...this.#arguments[i]], this.#results[i]]);
            }
        }
        return result;
    }

    printResults(){
        console.log(`Function: ${this.#function.name}`);
        let totaly = {"valid": 0, "invalid": 0, "failed": 0};
        for(let i = 0; i < this.#arguments.length; i ++){
            try{
                if(this.#function(...this.#arguments[i]) != this.#results[i]){
                    console.log(`Arguments: [${[...this.#arguments[i]]}], Correct result: ${this.#results[i]}, Desicion: INVALID`);
                    totaly["invalid"] ++;
                }
                else{
                    console.log(`Arguments: [${[...this.#arguments[i]]}], Correct result: ${this.#results[i]}, Desicion: VALID`);
                    totaly["valid"] ++;
                }
            }
            catch(err){
                console.log(`Arguments: [${[...this.#arguments[i]]}], Correct result: ${this.#results[i]}, Desicion: FAILED ( ${err} )`);
                totaly["failed"] ++;
            }
        }
        console.log(`Totaly: ${totaly["valid"]} VALID, ${totaly["invalid"]} INVALID, ${totaly["failed"]} FAILED`);
    }

}