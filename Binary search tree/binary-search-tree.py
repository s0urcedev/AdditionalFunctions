class Node:

    value = None
    left = None
    right = None

    def __init__(self, value: int = None, left = None, right = None) -> None:
        self.value = value
        self.left = left
        self.right = right

class Tree:

    __head = None

    def __init__(self, head: int = None) -> None:
        if head != None:
            self.__head = Node(head)

    def add_node(self, v: int, node = None) -> None:
        if self.__head == None:
            self.__head = Node(v)
            return
        if node == None:
            node = self.__head
        if v < node.value:
            if node.left == None:
                node.left = Node(v)
            else:
                self.add_node(v, node.left)
        else:
            if node.right == None:
                node.right = Node(v)
            else:
                self.add_node(v, node.right)

    def create(self, arr: list) -> None:
        self.__head = Node(arr[0])
        for a in arr[1:]:
            self.add_node(a, self.__head)

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
        res = [[] for _ in range(0, p[-1][1] + 1)]
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

    def get_min(self, node: Node = None) -> int:
        if node == None:
            node = self.__head
        if node.left != None:
            return self.get_min(node.left)
        else:
            return node.value

    def get_max(self, node: Node = None) -> int:
        if node == None:
            node = self.__head
        if node.right != None:
            return self.get_min(node.right)
        else:
            return node.value


t = Tree()
t.create([1, 4, 2, 3, 5])
print(t.get_tree_list())
print(t.get_tree_by_levels())