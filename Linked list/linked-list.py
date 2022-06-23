from typing import Any

class Node:

    value = None
    prev = None
    next = None

    def __init__(self, value, prev = None, next = None) -> None:
        self.value = value
        self.prev = prev
        self.next = next

class LinkedList:

    head: Node = None
    tail: Node = None
    length: int = 0

    def __init__(self, value: int = None) -> None:
        if value != None:
            self.head = Node(value, None, None)
            self.length = 1
        else:
            self.head = None
            self.length = 0
        self.tail = None

    def add(self, value: int) -> None:
        if self.head == None:
            self.head = Node(value, None, None)
        elif self.tail == None:
            self.tail = Node(value, self.head, None)
            self.head.next = self.tail
        else:
            self.tail.next = Node(value, self.tail, None)
            self.tail = self.tail.next
        self.length += 1

    def shift(self) -> None:
        self.head = self.head.next
        self.length -= 1

    def pop(self) -> None:
        if self.length == 1:
            self.shift()
        else:
            self.tail.prev = None
            self.tail = self.tail.prev
            self.length -= 1

    def remove(self, n: int) -> None:
        if n < 0:
            n = self.length + n
        if self.length == 0:
            raise "List is empty"
        if n >= self.length:
            raise "Index is bigger than length"
        if n == 0:
            self.shift()
        elif n == self.length - 1:
            self.pop()
        elif n < self.length / 2:
            node = self.head
            for _ in range(0, n):
                node = node.next
            node.next.prev = node.prev
            node.prev.next = node.next
            self.length -= 1
        else:
            node = self.tail
            for _ in range(self.length - 1, n, -1):
                node = node.prev
            node.next.prev = node.prev
            node.prev.next = node.next
            self.length -= 1
    
    def get_node(self, n: int) -> Node:
        if n < 0:
            n = self.length + n
        if self.length == 0:
            raise "List is empty"
        if n >= self.length:
            raise "Index is bigger than length"
        if n == 0:
            return self.head
        elif n == self.length - 1:
            return self.tail
        elif n < self.length / 2:
            node = self.head
            for _ in range(0, n):
                node = node.next
            return node
        else:
            node = self.tail
            for _ in range(self.length - 1, n, -1):
                node = node.prev
            return node
    
    def get(self, n: int) -> Any:
        return self.get_node(n)