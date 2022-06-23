package main

type Node[T any] struct {
	Value T
	Prev  *Node[T]
	Next  *Node[T]
}

type LinkedList[T any] struct {
	Head   *Node[T]
	Tail   *Node[T]
	Length uint
}

func NewEmptyLinkedList[T any]() LinkedList[T] {
	return LinkedList[T]{nil, nil, 0}
}

func NewLinkedList[T any](value T) LinkedList[T] {
	return LinkedList[T]{&Node[T]{value, nil, nil}, nil, 1}
}

func (ll *LinkedList[T]) Add(value T) {
	if ll.Head == nil {
		ll.Head = &Node[T]{value, nil, nil}
	} else if ll.Tail == nil {
		ll.Tail = &Node[T]{value, ll.Head, nil}
		ll.Head.Next = ll.Tail
	} else {
		ll.Tail.Next = &Node[T]{value, ll.Tail, nil}
		ll.Tail = ll.Tail.Next
	}
	ll.Length++
}

func (ll *LinkedList[T]) Shift() {
	ll.Head = ll.Head.Next
	ll.Length--
}

func (ll *LinkedList[T]) Pop() {
	if ll.Length == 1 {
		ll.Shift()
	} else {
		ll.Tail.Prev.Next = nil
		ll.Tail = ll.Tail.Prev
		ll.Length--
	}
}

func (ll *LinkedList[T]) Remove(n int) {
	if n < 0 {
		n = int(ll.Length) + n
	}
	if ll.Length == 0 {
		panic("List is empty")
	}
	if n >= int(ll.Length) {
		panic("Index is bigger than length")
	}
	if n == 0 {
		ll.Shift()
	} else if n == int(ll.Length)-1 {
		ll.Pop()
	} else if n < int(ll.Length)/2 {
		node := ll.Head
		for i := 0; i < n; i++ {
			node = node.Next
		}
		node.Next.Prev = node.Prev
		node.Prev.Next = node.Next
		ll.Length--
	} else {
		node := ll.Tail
		for i := int(ll.Length) - 1; i > n; i-- {
			node = node.Prev
		}
		node.Next.Prev = node.Prev
		node.Prev.Next = node.Next
		ll.Length--
	}
}

func (ll *LinkedList[T]) GetNode(n int) *Node[T] {
	if n < 0 {
		n = int(ll.Length) + n
	}
	if ll.Length == 0 {
		panic("List is empty")
	}
	if n >= int(ll.Length) {
		panic("Index is bigger than length")
	}
	if n == 0 {
		return ll.Head
	} else if n == int(ll.Length)-1 {
		return ll.Tail
	} else if n < int(ll.Length)/2 {
		node := ll.Head
		for i := 0; i < n; i++ {
			node = node.Next
		}
		return node
	} else {
		node := ll.Tail
		for i := int(ll.Length) - 1; i > n; i-- {
			node = node.Prev
		}
		return node
	}
}

func (ll *LinkedList[T]) Get(n int) T {
	return ll.GetNode(n).Value
}

func main() {
}
