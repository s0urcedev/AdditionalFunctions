class Node{
    
    value = undefined;
    prev = undefined;
    next = undefined;

    constructor(value, prev = undefined, next = undefined){
        this.value = value;
        this.prev = prev;
        this.next = next;
    }

}

class LinkedList{

    head = undefined;
    tail = undefined;
    length = 0;

    constructor(value = undefined){
        if(value != undefined){
            this.head = new Node(value, undefined, undefined);
            this.length = 1;
        }
        else{
            this.head = undefined;
            this.length = 0;
        }
        this.tail = undefined;
    }

    add(value){
        if(this.head == undefined){
            this.head = new Node(value, undefined, undefined);
        }
        else if(this.tail == undefined){
            this.tail = new Node(value, this.head, undefined);
            this.head.next = this.tail;
        }
        else{
            this.tail.next = new Node(value, this.tail, undefined);
            this.tail = this.tail.next;
        }
        this.length ++;
    }

    shift(){
        this.head = this.head.next;
        this.length --;
    }

    pop(){
        if(this.length == 1){
            this.shift();
        }
        else{
            this.tail.prev = undefined;
            this.tail = this.tail.prev;
            this.length --;
        }
    }

    remove(n){
        if(n < 0){
            n = this.length + n;
        }
        if(this.length == 0){
            throw "List is empty";
        }
        if(n >= this.length){
            throw "Index is bigger than length";
        }
        if(n == 0){
            this.shift();
        }
        else if(n == this.length - 1){
            this.pop();
        }
        else if(n < this.length / 2){
            let node = this.head;
            for(let _ = 0; _ < n; _ ++){
                node = node.next;
            }
            node.next.prev = node.prev;
            node.prev.next = node.next;
            this.length --;
        }
        else{
            let node = this.tail;
            for(let _ = this.length - 1; _ > n; _ --){
                node = node.prev;
            }
            node.next.prev = node.prev;
            node.prev.next = node.next;
            this.length --;
        }
    }

    getNode(n){
        if(n < 0){
            n = this.length + n;
        }
        if(this.length == 0){
            throw "List is empty";
        }
        if(n >= this.length){
            throw "Index is bigger than length";
        }
        if(n == 0){
            return this.head;
        }
        else if(n == this.length - 1){
            return this.tail;
        }
        else if(n < this.length / 2){
            let node = this.head;
            for(let _ = 0; _ < n; _ ++){
                node = node.next;
            }
            return node;
        }
        else{
            let node = this.tail;
            for(let _ = this.length - 1; _ > n; _ --){
                node = node.prev;
            }
            return node;
        }
    }

    get(n){
        return this.getNode(n);
    }

}