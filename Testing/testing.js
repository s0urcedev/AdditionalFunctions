class Test{
    
    #func = null;
    #params = [];
    #results = [];

    constructor(){

    }

    set function(func){
        this.#func = func;
    }

    addTestCases(){
        for(let a of arguments){
            this.#params.push(a[0]);
            this.#results.push(a[1]);
        }
    }

    testAll(){
        for(let i = 0; i < this.#params.length; i ++){
            if(this.#func(...this.#params[i]) != this.#results[i]){
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
        for(let i = 0; i < this.#params; i ++){
            try{
                if(this.#func(...this.#params[i]) == this.#results[i]){
                    result.push([[...this.#params[i]], this.#results[i]]);
                }
            }
            catch(err){

            }
        }
        return result;
    }

    findInvalid(){
        let result = [];
        for(let i = 0; i < this.#params; i ++){
            try{
                if(this.#func(...this.#params[i]) != this.#results[i]){
                    result.push([[...this.#params[i]], this.#results[i]]);
                }
            }
            catch(err){

            }
        }
        return result;
    }

    findFailed(){
        let result = [];
        for(let i = 0; i < this.#params; i ++){
            try{
                this.#func(...this.#params[i]);
            }
            catch(err){
                result.push([[...this.#params[i]], this.#results[i]]);
            }
        }
        return result;
    }

    printResults(){
        console.log(`Function: ${this.#func.name}`);
        let totaly = {"valid": 0, "invalid": 0, "failed": 0};
        for(let i = 0; i < this.#params.length; i ++){
            try{
                if(this.#func(...this.#params[i]) != this.#results[i]){
                    console.log(`Arguments: [${[...this.#params[i]]}], Correct result: ${this.#results[i]}, Desicion: INVALID`);
                    totaly["invalid"] ++;
                }
                else{
                    console.log(`Arguments: [${[...this.#params[i]]}], Correct result: ${this.#results[i]}, Desicion: VALID`);
                    totaly["valid"] ++;
                }
            }
            catch(err){
                console.log(`Arguments: [${[...this.#params[i]]}], Correct result: ${this.#results[i]}, Desicion: FAILED ( ${err} )`);
                totaly["failed"] ++;
            }
        }
        console.log(`Totaly: ${totaly["valid"]} VALID, ${totaly["invalid"]} INVALID, ${totaly["failed"]} FAILED`);
    }

}