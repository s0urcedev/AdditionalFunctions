using System;

namespace Base
{

    class Node
    {
        public int value;
        public uint height;
        public Node left;
        public Node right;

        public Node(int d)
        {
            value = d;
            height = 1;
            left = null;
            right = null;
        }

    }

    class Tree
    {
        private Node _head;

        public Tree()
        {
            _head = null;
        }

        private void _FixHeight(Node node)
        {
            uint hl = node.left != null ? node.left.height : 0;
            uint hr = node.right != null ? node.right.height : 0;            
            node.height = (hl > hr ? hl : hr) + 1;
        }

        private Node _RotateRight(Node node)
        {
            Node v = node.left;
            node.left = v.right;
            v.right = node;
            this._FixHeight(node);
            this._FixHeight(v);
            return v;
        }

        private Node _RotateLeft(Node node)
        {
            Node v = node.right;
            node.right = v.left;
            v.left = node;
            this._FixHeight(node);
            this._FixHeight(v);
            return v;
        }

        private int _BFactor(Node node)
        {
            return (node.right != null ? node.right.height : 0) - (node.left != null ? node.left.height : 0);
        }

        private Node _Balance(Node node)
        {
            this._FixHeight(node);
            if(this._BFactor(node) == 2)
            {
                if(this._BFactor(node.right) < 0)
                {
                    node.right = this._RotateRight(node.right);
                }
                return this._RotateLeft(node);
            }
            else if(this._BFactor(node) == -2)
            {
                if(this._BFactor(node.left) > 0)
                {
                    node.left = this._RotateLeft(node.left);
                }
                return _RotateRight(node);
            }
            return node;
        }

        private Node _GetMinNode(Node node)
        {
            if(node.left != null)
            {
                return _GetMinNode(node.left);
            }
            else
            {
                return node;
            }
        }

        public int GetMin()
        {
            if(this._head.left != null)
            {
                return this._GetMinNode(this._head).value;
            }
            else
            {
                return this._head.value;
            }
        }

        private Node _GetMaxNode(Node node)
        {
            if(node.right != null)
            {
                return _GetMaxNode(node.right);
            }
            else
            {
                return node;
            }
        }

        public int GetMax()
        {
            if(this._head.left != null)
            {
                return this._GetMaxNode(this._head).value;
            }
            else
            {
                return this._head.value;
            }
        }

        private void _AddNode(int v, Node node = null)
        {
            if(node == null)
            {
                return new Node(v);
            }
            if(v < node.value)
            {
                node.left = _AddNode(v, node.left);
            }
            else
            {
                node.right = _AddNode(v, node.right);
            }
            return this._Balance(node);
        }

        public void Add(int v)
        {
            this._head = this._AddNode(v, this._head);
        }

        private Node _RemoveMinNode(Node node)
        {
            if(node.left == null)
            {
                return node.right;
            }
            node.left = this._RemoveMinNode(node.left);
            return this._Balance(node);
        }

        public void RemoveMin()
        {
            this._head = this._RemoveMinNode(this._head);
        }

        private Node _RemoveMaxNode(Node node)
        {
            if(node.right == null)
            {
                return node.left;
            }
            node.right = this._RemoveMaxNode(node.left);
            return this._Balance(node);
        }

        public void RemoveMax()
        {
            this._head = this._RemoveMaxNode(this._head);
        }

        private Node _RemoveNode(int v, Node node)
        {
            if(node == null)
            {
                return null;
            }
            if(v < node.value)
            {
                node.left = this._RemoveNode(v, node.left);
            }
            else if(v > node.value)
            {
                node.right = this._RemoveNode(v, node.right);
            }
            else
            {
                Node l = node.left;
                Node r = node.right;
                if(r == null)
                {
                    return l;
                }
                Node min = this._GetMinNode(r);
                min.right = this._RemoveMinNode(r);
                min.left = l;
                return this._Balance(min);
            }
            return this._Balance(node);
        }

        public void Remove(int v)
        {
            this._head = this._RemoveNode(v, this._head);
        }

        public void Create(List<int> arr)
        {
            _head = new Node(arr[0]);
            for(int i = 1; i < arr.Count(); i ++)
            {
                AddNode(arr[i], _head);
            }
        }

        private List<(int, int)> _Bfs()
        {
            List<(Node, int)> q = new List<(Node, int)>(1){(_head, 0)};
            List<(int, int)> p = new List<(int, int)>(){};
            while(q.Count() > 0)
            {
                (Node, int) v = q[^1];
                q.RemoveAt(q.Count() - 1);
                p.Add((v.Item1.value, v.Item2));
                if(v.Item1.right != null)
                {
                    q.Add((v.Item1.right, v.Item2 + 1));
                }
                if(v.Item1.left != null)
                {
                    q.Add((v.Item1.left, v.Item2 + 1));
                }
            }
            return p;
        }

        public List<List<int>> GetTreeByLevels()
        {
            List<(int, int)> p = _Bfs();
            List<List<int>> res = new List<List<int>>(){};
            int maxP = -1;
            foreach((int, int) n in p)
            {
                if(maxP < n.Item2)
                {
                    maxP = n.Item2;
                }
            }
            for(int _ = 0; _ <= maxP; _ ++)
            {
                res.Add(new List<int>(){});
            }
            foreach((int, int) n in p)
            {
                res[n.Item2].Add(n.Item1);
            }
            return res;
        }

        public List<int> GetTreeList()
        {
            List<(int, int)> p = _Bfs();
            List<int> res = new List<int>(){};
            foreach((int, int) n in p)
            {
                res.Add(n.Item1);
            }
            return res;
        }

        private void _DfsPlain(Node node, ref List<int> p)
        {
            if(node.left != null)
            {
                _DfsPlain(node.left, ref p);
            }
            p.Add(node.value);
            if(node.right != null)
            {
                _DfsPlain(node.right, ref p);
            }
        }

        private void _DfsReverse(Node node, ref List<int> p)
        {
            if(node.right != null)
            {
                _DfsReverse(node.right, ref p);
            }p.Add(node.value);
            if(node.left != null)
            {
                _DfsReverse(node.left, ref p);
            }
        }

        public List<int> GetTreeSorted(bool reverse = false)
        {
            List<int> p = new List<int>(){};
            if(reverse)
            {
                _DfsReverse(_head, ref p);
            }
            else
            {
                _DfsPlain(_head, ref p);
            }
            return p;
        }
    }

    class Program
    {

        public static void Main()
        {
            Console.ReadLine();
        }
    }
}