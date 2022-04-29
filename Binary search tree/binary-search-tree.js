class Node{

    value = undefined;
    left = undefined;
    right = undefined;

    constructor(value = undefined, left = undefined, right = undefined){
        this.value = value;
        this.left = left;
        this.right = right;
    }
}

class Tree{

    #head = undefined;

    constructor(head = undefined){
        if(head != undefined){
            this.#head = head;
        }
    }

    addNode(v, node = undefined){
        if(this.#head == undefined){
            this.#head = new Node(v);
            return;
        }
        if(node == undefined){
            node = this.#head;
        }
        if(v < node.value){
            if(node.left == undefined){
                node.left = new Node(v);
            }
            else{
                this.addNode(v, node.left);
            }
        }
        else{
            if(node.right == undefined){
                node.right = new Node(v);
            }
            else{
                this.addNode(v, node.right);
            }
        }
    }

    create(arr){
        this.#head = new Node(arr[0]);
        for(let a of arr.slice(1, arr.length)){
            this.addNode(a, this.#head);
        }
    }

    #bfs(){
        let q = [[this.#head, 0]];
        let p = [];
        while(q.length > 0){
            let v = q.pop();
            p.push([v[0].value, v[1]]);
            if(v[0].right != undefined){
                q.push([v[0].right, v[1] + 1]);
            }
            if(v[0].left != undefined){
                q.push([v[0].left, v[1] + 1]);
            }
        }
        return p;
    }

    get treeByLevels(){
        let p = this.#bfs();
        let res = [];
        for(let _ = 0; _ < p[p.length - 1][1] + 1; _ ++){
            res.push([]);
        }
        for(let n of p){
            res[n[1]].push(n[0]);
        }
        return res;
    }

    get treeList(){
        let p = this.#bfs();
        let res = [];
        for(let n of p){
            res.push(n[0]);
        }
        return res;
    }

    #dfsNodes(node, p){
        p[node.value] = [];
        if(node.left != undefined){
            p[node.value].push(node.left.value);
            this.#dfsNodes(node.left, p);
        }
        if(node.right != undefined){
            p[node.value].push(node.right.value);
            this.#dfsNodes(node.right, p);
        }
    }

    get treeByNodes(){
        let p = {};
        this.#dfsNodes(this.#head, p);
        return p;
    }

    #dfsPlain(node, p){
        if(node.left != undefined){
            this.#dfsPlain(node.left, p);
        }
        p.push(node.value);
        if(node.right != undefined){
            this.#dfsPlain(node.right, p);
        }
    }

    #dfsReverse(node, p){
        if(node.right != undefined){
            this.#dfsReverse(node.right, p);
        }
        p.push(node.value);
        if(node.left != undefined){
            this.#dfsReverse(node.left, p);
        }
    }

    get treeSorted(){
        let p = [];
        this.#dfsPlain(this.#head, p);
        return p;
    }

    get treeSortedReverse(){
        let p = [];
        this.#dfsReverse(this.#head, p);
        return p;
    }

    #getMin(node){
        if(node.left != undefined){
            return this.#getMin(node.left);
        }
        else{
            return node.value;
        }
    }

    get min(){
        return this.#getMin(this.#head);
    }

    #getMax(node){
        if(node.right != undefined){
            return this.#getMax(node.right);
        }
        else{
            return node.value;
        }
    }

    get max(){
        return this.#getMax(this.#head);
    }
}