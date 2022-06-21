package main

type Pair[T1 any, T2 any] struct {
	First  T1
	Second T2
}

type Number interface {
	int | int8 | int16 | int32 | int64 | uint | uint8 | uint16 | uint32 | uint64 | float32 | float64
}

type Node[T Number] struct {
	Value  T
	Left   *Node[T]
	Right  *Node[T]
	Height uint
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

func (t Tree[T]) FixHeight(node *Node[T]) {
	var hl, hr uint
	if node.Left != nil {
		hl = node.Left.Height
	} else {
		hl = 0
	}
	if node.Right != nil {
		hr = node.Right.Height
	} else {
		hr = 0
	}
	if hl > hr {
		node.Height = hl + 1
	} else {
		node.Height = hr + 1
	}
}

func (t Tree[T]) RotateRight(node *Node[T]) *Node[T] {
	v := node.Left
	node.Left = v.Right
	v.Right = node
	t.FixHeight(node)
	t.FixHeight(v)
	return v
}

func (t Tree[T]) RotateLeft(node *Node[T]) *Node[T] {
	v := node.Right
	node.Right = v.Left
	v.Left = node
	t.FixHeight(node)
	t.FixHeight(v)
	return v
}

func (t Tree[T]) BFactor(node *Node[T]) int {
	if node.Left != nil && node.Right != nil {
		return int(node.Right.Height) - int(node.Left.Height)
	} else if node.Left != nil {
		return -int(node.Left.Height)
	} else if node.Right != nil {
		return int(node.Right.Height)
	}
	return 0
}

func (t Tree[T]) Balance(node *Node[T]) *Node[T] {
	t.FixHeight(node)
	if t.BFactor(node) == 2 {
		if t.BFactor(node.Right) < 0 {
			node.Right = t.RotateRight(node.Right)
		}
		return t.RotateLeft(node)
	} else if t.BFactor(node) == -2 {
		if t.BFactor(node.Left) > 0 {
			node.Left = t.RotateLeft(node.Left)
		}
		return t.RotateRight(node)
	}
	return node
}

func (t Tree[T]) MinNode(node *Node[T]) *Node[T] {
	if node.Left != nil {
		return t.MinNode(node.Left)
	} else {
		return node
	}
}

func (t Tree[T]) Min() T {
	if t.Head.Left != nil {
		return t.MinNode(t.Head.Left).Value
	} else {
		return t.Head.Value
	}
}

func (t Tree[T]) MaxNode(node *Node[T]) *Node[T] {
	if node.Right != nil {
		return t.MinNode(node.Right)
	} else {
		return node
	}
}

func (t Tree[T]) Max() T {
	if t.Head.Right != nil {
		return t.MinNode(t.Head.Right).Value
	} else {
		return t.Head.Value
	}
}

func (t Tree[T]) AddNode(v T, node *Node[T]) *Node[T] {
	if node == nil {
		return &Node[T]{v, nil, nil, 1}
	}
	if v < node.Value {
		node.Left = t.AddNode(v, node.Left)
	} else {
		node.Right = t.AddNode(v, node.Right)
	}
	return t.Balance(node)
}

func (t *Tree[T]) Add(v T) {
	t.Head = t.AddNode(v, t.Head)
}

func (t Tree[T]) RemoveMinNode(node *Node[T]) *Node[T] {
	if node.Left == nil {
		return node.Right
	}
	node.Left = t.RemoveMinNode(node.Left)
	return t.Balance(node)
}

func (t *Tree[T]) RemoveMin() {
	t.Head = t.RemoveMinNode(t.Head)
}

func (t Tree[T]) RemoveMaxNode(node *Node[T]) *Node[T] {
	if node.Right == nil {
		return node.Left
	}
	node.Left = t.RemoveMaxNode(node.Left)
	return t.Balance(node)
}

func (t *Tree[T]) RemoveMax() {
	t.Head = t.RemoveMaxNode(t.Head)
}

func (t Tree[T]) RemoveNode(v T, node *Node[T]) *Node[T] {
	if node == nil {
		return nil
	}
	if v < node.Value {
		node.Left = t.RemoveNode(v, node.Left)
	} else if v > node.Value {
		node.Right = t.RemoveNode(v, node.Right)
	} else {
		l := node.Left
		r := node.Right
		if r == nil {
			return l
		}
		min := t.MinNode(r)
		min.Right = t.RemoveMinNode(r)
		min.Left = l
		return t.Balance(min)
	}
	return t.Balance(node)
}

func (t *Tree[T]) Remove(v T) {
	t.Head = t.RemoveNode(v, t.Head)
}

func NewArrTree[T Number](arr []T) Tree[T] {
	t := Tree[T]{&Node[T]{arr[0], nil, nil, 1}}
	for i := 1; i < len(arr); i++ {
		t.Add(arr[i])
	}
	return t
}

func (t Tree[T]) BFS() []Pair[T, int] {
	q := []Pair[*Node[T], int]{{t.Head, 0}}
	p := []Pair[T, int]{}
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

func (t Tree[T]) DFSPlain(node *Node[T], p *[]T) {
	if node.Left != nil {
		t.DFSPlain(node.Left, p)
	}
	*p = append(*p, node.Value)
	if node.Right != nil {
		t.DFSPlain(node.Right, p)
	}
}

func (t Tree[T]) DFSReverse(node *Node[T], p *[]T) {
	if node.Right != nil {
		t.DFSReverse(node.Right, p)
	}
	*p = append(*p, node.Value)
	if node.Left != nil {
		t.DFSReverse(node.Left, p)
	}
}

func (t Tree[T]) TreeSorted() []T {
	p := []T{}
	t.DFSPlain(t.Head, &p)
	return p
}

func (t Tree[T]) TreeSortedReverse() []T {
	p := []T{}
	t.DFSReverse(t.Head, &p)
	return p
}

func main() {
}
