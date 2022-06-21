class Node{

    value = undefined;
    height = undefined;
    left = undefined;
    right = undefined;

    constructor(value = undefined, height = 1, left = undefined, right = undefined){
        this.value = value;
        this.height = height;
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

    #fixHeight(node){
        let hl = node.left != undefined ? node.left.height : 0;
        let hr = node.right != undefined ? node.right.height : 0;
        node.height = (hl > hr ? hl : hr) + 1;
    }

    #rotateRight(node){
        let v = node.left;
        node.left = v.right;
        v.right = node;
        this.#fixHeight(node);
        this.#fixHeight(v);
        return v;
    }

    #rotateLeft(node){
        let v = node.right;
        node.right = v.left;
        v.left = node;
        this.#fixHeight(node);
        this.#fixHeight(v);
        return v;
    }

    #bFactor(node){
        return (node.right != undefined ? node.right.height : 0) - (node.left != undefined ? node.left.height : 0);
    }

    #balance(node){
        this.#fixHeight(node);
        if(this.#bFactor(node) == 2){
            if(this.#bFactor(node.right) < 0){
                node.right = this.#rotateRight(node.right);
            }
            return this.#rotateLeft(node);
        }
        else if(this.#bFactor(node) == -2){
            if(this.#bFactor(node.left) > 0){
                node.left = this.#rotateLeft(node.left);
            }
            return this.#rotateRight(node);
        }
        return node;
    }

    #getMinNode(node){
        if(node.left != undefined){
            return this.#getMinNode(node.left);
        }
        else{
            return node;
        }
    }

    get min(){
        if(this.#head.left != undefined){
            return this.#getMinNode(this.#head.left);
        }
        else{
            return this.#head.value;
        }
    }

    #getMaxNode(node){
        if(node.right != undefined){
            return this.#getMaxNode(node.right);
        }
        else{
            return node;
        }
    }

    get max(){
        if(this.#head.right != undefined){
            return this.#getMaxNode(this.#head.right);
        }
        else{
            return this.#head.value;
        }
    }

    #addNode(v, node){
        if(node == undefined){
            return new Node(v);
        }
        if(v < node.value){
            node.left = this.#addNode(v, node.left);
        }
        else{
            node.right = this.#addNode(v, node.right);
        }
        return this.#balance(node);
    }

    add(v){
        this.#head = this.#addNode(v, this.#head);
    }

    #removeMinNode(node){
        if(node.left == undefined){
            return node.right;
        }
        node.left = this.#removeMinNode(node.left);
        return this.#balance(node);
    }

    removeMin(){
        this.#head = this.#removeMinNode(this.#head);
    }

    #removeMaxNode(node){
        if(node.right == undefined){
            return node.left;
        }
        node.right = this.#removeMaxNode(node.right);
        return this.#balance(node);
    }

    removeMax(){
        this.#head = this.#removeMaxNode(this.#head);
    }

    #removeNode(v, node){
        if(node == undefined){
            return undefined;
        }
        if(v < node.value){
            node.left = this.#removeNode(v, node.left);
        }
        else if(v > node.value){
            node.right = this.#removeNode(v, node.right);
        }
        else{
            let l = node.left;
            let r = node.right;
            if(r == undefined){
                return l;
            }
            let min = this.#getMinNode(r);
            min.right = this.#removeMinNode(r);
            min.left = l;
            return this.#balance(min);
        }
        return this.#balance(node);
    }

    remove(v){
        this.#head = this.#removeNode(v, this.#head);
    }

    create(arr){
        this.#head = new Node(arr[0]);
        for(let a of arr.slice(1, arr.length)){
            this.add(a);
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
        let maxP = -1;
        for(let n of p){
            if(maxP < n[1]){
                maxP = n[1]
            }
        }
        for(let _ = 0; _ <= maxP; _ ++){
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
}