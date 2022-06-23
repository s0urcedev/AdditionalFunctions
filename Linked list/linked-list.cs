using System;

namespace Base
{

    class Node<T>
    {
        public T value;
        public Node<T> next;
        public Node<T> prev;

        public Node(T v, Node<T> p = null, Node<T> n = null)
        {
            this.value = v;
            this.prev = p;
            this.next = n;
        }

    }

    class LinkedList<T>
    {
        public Node<T> head;
        public Node<T> tail;
        public uint length;

        public LinkedList()
        {
            this.head = null;
            this.length = 0;
            this.tail = null;
        }

        public LinkedList(T value)
        {
            this.head = new Node<T>(value);
            this.length = 1;
            this.tail = null;
        }

        public void Add(T value)
        {
            if(this.head == null)
            {
                this.head = new Node(value);
            }
            else if(this.tail == NULL)
            {
                this.tail = new Node(value, this.head);
                this.head.next = this.tail;
            }
            else
            {
                this.tail.next = new Node(value, this.tail);
                this.tail = this.tail.next;
            }
            this.length ++;
        }

        public void Shift()
        {
            this.head = this.head.next;
            this.length --;
        }

        public void Pop()
        {
            if(this.length == 1)
            {
                this.Shift();
            }
            else
            {
                this.tail.prev = null;
                this.tail = this.tail.prev;
                this.length --;
            }
        }

        public void Remove(int n)
        {
            if(n < 0)
            {
                n = this.length + n;
            }
            if(this.length == 0)
            {
                throw new Exception("List is empty");
            }
            if(n >= this.length)
            {
                throw new Exception("Index is bigger than length");
            }
            if(n == 0)
            {
                this.Shift();
            }
            else if(n == this.length - 1)
            {
                this.Pop();
            }
            else if(n < this.length / 2)
            {
                Node<T> node = this.head;
                for(int _ = 0; _ < n; _ ++)
                {
                    node = node.next;
                }
                node.next.prev = node.prev;
                node.prev.next = node.next;
                this.length --;
            }
            else
            {
                Node<T> node = this.tail;
                for(int _ = this.length - 1; _ > n; _ --)
                {
                    node = node.prev;
                }
                node.next.prev = node.prev;
                node.prev.next = node.next;
                this.length --;
            }
        }

        public void GetNode(int n)
        {
            if(n < 0)
            {
                n = this.length + n;
            }
            if(this.length == 0)
            {
                throw new Exception("List is empty");
            }
            if(n >= this.length)
            {
                throw new Exception("Index is bigger than length");
            }
            if(n == 0)
            {
                return this.head;
            }
            else if(n == this.length - 1)
            {
                return this.tail;
            }
            else if(n < this.length / 2)
            {
                Node<T> node = this.head;
                for(int _ = 0; _ < n; _ ++)
                {
                    node = node.next;
                }
                return node;
            }
            else
            {
                Node<T> node = this.tail;
                for(int _ = this.length - 1; _ > n; _ --)
                {
                    node = node.prev;
                }
                return node;
            }
        }

        public void Get(int n)
        {
            return this.GetNode(n);
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