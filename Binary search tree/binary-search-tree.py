class Node:

    value = None
    height = None
    left = None
    right = None

    def __init__(self, value: int = None, height: int = 1, left = None, right = None) -> None:
        self.value = value
        self.height = height
        self.left = left
        self.right = right

class Tree:

    __head = None

    def __init__(self, head: int = None) -> None:
        if head != None:
            self.__head = Node(head)

    def __fix_height(self, node: Node) -> None:
        hl = node.left.height if node.left != None else 0
        hr = node.right.height if node.right != None else 0 
        node.height = (hl if hl > hr else hr) + 1

    def __rotate_right(self, node: Node) -> Node:
        v = node.left
        node.left = v.right
        v.right = node
        self.__fix_height(node)
        self.__fix_height(v)
        return v

    def __rotate_left(self, node: Node) -> Node:
        v = node.right
        node.right = v.left
        v.left = node
        self.__fix_height(node)
        self.__fix_height(v)
        return v

    def __b_factor(self, node: Node) -> int:
        return (node.right.height if node.right != None else 0) - (node.left.height if node.left != None else 0)

    def __balance(self, node: Node) -> Node:
        self.__fix_height(node)
        if self.__b_factor(node) == 2:
            if self.__b_factor(node.right) < 0:
                node.right = self.__rotate_right(node.right)
            return self.__rotate_left(node)
        elif self.__b_factor(node) == -2:
            if self.__b_factor(node.left) > 0:
                node.left = self.__rotate_left(node.left)
            return self.__rotate_right(node)
        return node

    def __get_min_node(self, node: Node) -> Node:
        if node.left != None:
            return self.__get_min_node(node.left)
        else:
            return node

    def get_min(self) -> int:
        if self.__head.left != None:
            return self.__get_min_node(self.__head.left)
        else:
            return self.__head.value

    def __get_max_node(self, node: Node) -> Node:
        if node.right != None:
            return self.__get_max_node(node.right)
        else:
            return node

    def get_max(self) -> int:
        if self.__head.right != None:
            return self.__get_max_node(self.__head.right)
        else:
            return self.__head.value

    def __add_node(self, v: int, node: Node) -> None:
        if node == None:
            return Node(v)
        if v < node.value:
            node.left = self.__add_node(v, node.left)
        else:
            node.right = self.__add_node(v, node.right)
        return self.__balance(node)

    def add(self, v: int) -> None:
        self.__head = self.__add_node(v, self.__head)

    def __remove_min_node(self, node: Node) -> Node:
        if node.left == None:
            return node.right
        node.left = self.__remove_min_node(node.left)
        return self.__balance(node)

    def remove_min(self) -> None:
        self.__head = self.__remove_min_node(self.__head)

    def __remove_max_node(self, node: Node) -> Node:
        if node.right == None:
            return node.left
        node.right = self.__remove_max_node(node.right)
        return self.__balance(node)

    def remove_max(self) -> None:
        self.__head = self.__remove_max_node(self.__head)

    def __remove_node(self, v: int, node: Node) -> Node:
        if node == None:
            return None
        if v < node.value:
            node.left = self.__remove_node(v, node.left)
        elif v > node.value:
            node.right = self.__remove_node(v, node.right)
        else:
            l = node.left
            r = node.right
            if r == None:
                return l
            min = self.__get_min_node(r)
            min.right = self.__remove_min_node(r)
            min.left = l
            return self.__balance(min)
        return self.__balance(node)

    def remove(self, v: int) -> Node:
        self.__head = self.__remove_node(v, self.__head)

    def create(self, arr: list) -> None:
        self.__head = Node(arr[0])
        for a in arr[1:]:
            self.add(a)

    def __bfs(self) -> list:
        q = [[self.__head, 0]]
        p = []
        while len(q) > 0:
            v = q.pop()
            p.append([v[0].value, v[1]])
            if v[0].right != None:
                q.append([v[0].right, v[1] + 1])
            if v[0].left != None:
                q.append([v[0].left, v[1] + 1])
        return p

    def get_tree_by_levels(self) -> list:
        p = self.__bfs()
        max_p = -1
        for m in p:
            if max_p < m[1]:
                max_p = m[1]
        res = [[] for _ in range(0, max_p + 1)]
        for n in p:
            res[n[1]].append(n[0])
        return res

    def get_tree_list(self) -> list:
        p = self.__bfs()
        res = []
        for n in p:
            res.append(n[0])
        return res

    def __dfs_nodes(self, node: Node, p: dict) -> None:
        p[node.value] = []
        if node.left != None:
            p[node.value].append(node.left.value)
            self.__dfs_nodes(node.left, p)
        if node.right != None:
            p[node.value].append(node.right.value)
            self.__dfs_nodes(node.right, p)

    def get_tree_by_nodes(self) -> dict:
        p = {}
        self.__dfs_nodes(self.__head, p)
        return p

    def __dfs_plain(self, node: Node, p: list) -> None:
        if node.left != None:
            self.__dfs_plain(node.left, p)
        p.append(node.value)
        if node.right != None:
            self.__dfs_plain(node.right, p)
    
    def __dfs_reverse(self, node: Node, p: list) -> None:
        if node.right != None:
            self.__dfs_reverse(node.right, p)
        p.append(node.value)
        if node.left != None:
            self.__dfs_reverse(node.left, p)

    def get_tree_sorted(self, reverse: bool = False) -> list:
        p = []
        if reverse:
            self.__dfs_reverse(self.__head, p)
        else:
            self.__dfs_plain(self.__head, p)
        return p