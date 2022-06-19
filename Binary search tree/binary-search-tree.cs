using System;

namespace Base
{

    class Node
    {
        public int value;
        public Node left;
        public Node right;

        public Node(int d)
        {
            value = d;
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

        public void AddNode(int v, Node node = null)
        {
            if(_head == null)
            {
                _head = new Node(v);
                return;
            }
            if(node == null)
            {
                node = _head;
            }
            if(v < node.value)
            {
                if(node.left == null)
                {
                    node.left = new Node(v);
                }
                else
                {
                    AddNode(v, node.left);
                }
            }
            else
            {
                if(node.right == null)
                {
                    node.right = new Node(v);
                }
                else
                {
                    AddNode(v, node.right);
                }
            }
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

        public int GetMin(Node node = null)
        {
            if(node == null)
            {
                node = _head;
            }
            if(node.left != null)
            {
                return GetMin(node.left);
            }
            else
            {
                return node.value;
            }
        }

        public int GetMax(Node node = null)
        {
            if(node == null)
            {
                node = _head;
            }
            if(node.right != null)
            {
                return GetMax(node.right);
            }
            else
            {
                return node.value;
            }
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