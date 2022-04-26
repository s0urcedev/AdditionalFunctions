class Test{
    
    #func = null;
    #params = [];
    #results = [];

    /**
     * @param {Function} func;
     * @param {Array} params;
     * @param {Array} results;
     */

    constructor(func = null){
        this.#func = func;
    }

    set func(func){
        this.#func = func;
    }

    get func(){
        return this.#func;
    }
    
    test(){
        if(arguments.length === 2){
            if(this.#func === null){
                console.log("No function set");
                return;
            }
            return this.#func(...arguments[0]) === arguments[1];
        }
        else if(arguments.length === 3){
            return arguments[0](...arguments[1]) === arguments[2];
        }
        else{
            console.log("Invalid number of arguments");
            return;
        }
    }

    addTestCases(){
        for(let a of arguments){
            this.#params.push(a[0]);
            this.#results.push(a[1]);
        }
    }

    showTestCases(){
        if(this.#params.length === 0){
            console.log("No test cases");
        }
        for(let i = 0; i < this.#params.length; i ++){
            console.log(`Arguments: [${[...this.#params[i]]}], Correct result: ${this.#results[i]}`);
        }
    }

    clearTestCases(){
        this.#params = [];
        this.#results = [];
    }

    testAll(){
        if(this.#func == null){
            console.log("No function set"); 
            return;
        }
        for(let i = 0; i < this.#params.length; i ++){
            if(this.#func(...this.#params[i]) !== this.#results[i]){
                return false;
            }
        }
        return true;
    }

    findValid(){
        if(this.#func == null){
            console.log("No function set"); 
            return;
        }
        let result = [];
        for(let i = 0; i < this.#params; i ++){
            try{
                if(this.#func(...this.#params[i]) === this.#results[i]){
                    result.push([[...this.#params[i]], this.#results[i]]);
                }
            }
            catch(err){

            }
        }
        return result;
    }

    findInvalid(){
        if(this.#func == null){
            console.log("No function set"); 
            return;
        }
        let result = [];
        for(let i = 0; i < this.#params; i ++){
            try{
                if(this.#func(...this.#params[i]) !== this.#results[i]){
                    result.push([[...this.#params[i]], this.#results[i]]);
                }
            }
            catch(err){

            }
        }
        return result;
    }

    findFailed(){
        if(this.#func == null){
            console.log("No function set"); 
            return;
        }
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
        if(this.#func == null){
            console.log("No function set"); 
            return;
        }
        console.log(`Function: ${this.#func.name}`);
        let totaly = {"valid": 0, "invalid": 0, "failed": 0};
        for(let i = 0; i < this.#params.length; i ++){
            try{
                if(this.#func(...this.#params[i]) !== this.#results[i]){
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