package main

type Pair[T1 any, T2 any] struct {
	First  T1
	Second T2
}

type Number interface {
	int | int8 | int16 | int32 | int64 | uint | uint8 | uint16 | uint32 | uint64 | float32 | float64
}

type Node[T Number] struct {
	Value T
	Left  *Node[T]
	Right *Node[T]
}

type Tree[T Number] struct {
	Head *Node[T]
}

func NewTree[T Number]() Tree[T] {
	t := Tree[T]{nil}
	return t
}

func NewHeadTree[T Number](head *Node[T]) Tree[T] {
	t := Tree[T]{head}
	return t
}

func (t Tree[T]) AddNode(v T, node *Node[T]) {
	if v < node.Value {
		if node.Left == nil {
			node.Left = &Node[T]{v, nil, nil}
		} else {
			t.AddNode(v, node.Left)
		}
	} else {
		if node.Right == nil {
			node.Right = &Node[T]{v, nil, nil}
		} else {
			t.AddNode(v, node.Right)
		}
	}
}

func NewArrTree[T Number](arr []T) Tree[T] {
	t := Tree[T]{&Node[T]{arr[0], nil, nil}}
	for i := 1; i < len(arr); i++ {
		t.AddNode(arr[i], t.Head)
	}
	return t
}

func (t Tree[T]) BFS() []Pair[T, int] {
	q := []Pair[*Node[T], int]{{t.Head, 0}}
	p := []Pair[T, int]{{}}
	for len(q) > 0 {
		v := q[len(q)-1]
		q = q[:len(q)-1]
		p = append(p, Pair[T, int]{v.First.Value, v.Second})
		if v.First.Right != nil {
			q = append(q, Pair[*Node[T], int]{v.First.Right, v.Second + 1})
		}
		if v.First.Left != nil {
			q = append(q, Pair[*Node[T], int]{v.First.Left, v.Second + 1})
		}
	}
	return p
}

func (t Tree[T]) TreeByLevels() [][]T {
	p := t.BFS()
	res := [][]T{{}}
	maxP := -1
	for _, m := range p {
		if maxP < m.Second {
			maxP = m.Second
		}
	}
	for i := 0; i <= maxP; i++ {
		res = append(res, []T{})
	}
	for _, n := range p {
		res[n.Second] = append(res[n.Second], n.First)
	}
	return res
}

func (t Tree[T]) TreeList() []T {
	p := t.BFS()
	res := []T{}
	for _, n := range p {
		res = append(res, n.First)
	}
	return res
}

func (t Tree[T]) DFSPlain(node *Node[T], p []T) {
	if node.Left != nil {
		t.DFSPlain(node.Left, p)
	}
	p = append(p, node.Value)
	if node.Right != nil {
		t.DFSPlain(node.Right, p)
	}
}

func (t Tree[T]) DFSReverse(node *Node[T], p []T) {
	if node.Right != nil {
		t.DFSPlain(node.Right, p)
	}
	p = append(p, node.Value)
	if node.Left != nil {
		t.DFSPlain(node.Left, p)
	}
}

func (t Tree[T]) TreeSorted() []T {
	p := []T{}
	t.DFSPlain(t.Head, p)
	return p
}

func (t Tree[T]) TreeSortedReverse() []T {
	p := []T{}
	t.DFSReverse(t.Head, p)
	return p
}

func (t Tree[T]) Min(node *Node[T]) T {
	if node.Left != nil {
		return t.Min(node.Left)
	} else {
		return node.Value
	}
}

func (t Tree[T]) Max(node *Node[T]) T {
	if node.Right != nil {
		return t.Min(node.Right)
	} else {
		return node.Value
	}
}

func main() {
}
