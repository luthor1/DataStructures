using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.classes
{
    internal class LinkedList
    {
        private Node? head;
        private Node? tail;
        private int size;
        public int Size { get { return size; } }
        public Node? Head { get { return head; } }
        public Node? Tail { get { return tail; } }

        public LinkedList()
        {
            this.head = null;
            this.tail = null;
            this.size = 0;
        }
        public LinkedList(int data)
        {
            Node newNode = new Node(data);
            this.head = newNode;
            this.tail = newNode;
            this.size = 1;
        }

        public void Append(int data)
        {
            Node newNode = new Node(data);
            if(this.size == 0)
            {
                this.head = newNode;
                this.tail = newNode;
            }
            else
            {
                this.tail!.next = newNode;
                this.tail = newNode;
            }
            this.size++;
        }

        public void Print()
        {
            Node? temp = this.head;

            while(temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
            Console.WriteLine("--------------");
        }

        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            if(this.size == 0)
            {
                this.head = newNode;
                this.tail = newNode;
            }
            else
            {
                newNode.next = this.head;
                this.head = newNode;
            }
            this.size++;
        }

        public void Insert(int index, int data)
        {
            if(index <= 0) AddFirst(data);

            else if(index >= 0 && index < this.size)
            {
                Node newNode = new Node(data);
                Node temp = GetNode(index - 1);
                newNode.next = temp.next;
                temp.next = newNode;
                this.size++;
            }

            else
            { 
                Append(data);
            }
           
        }

        public Node? RemoveLast()
        {
            if(this.size == 0) return null;
            Node? temp = this.head;
            Node? last = this.tail;
            while(temp!.next != null)
            {
                last = temp;
                temp = temp.next;
            }
            this.tail = last;
            this.tail!.next = null;
            if(this.size == 1)
            {
                this.head = null;
                this.tail = null;
            }
            this.size--;
            return temp;
        }

        public Node? RemoveFirst()
        {
            if(this.head ==  null) return null;

            else if(this.size == 1)
            {
                Node? ex = this.head;
                this.head = null;
                this.tail = null;
                this.size--;
                return ex;
            }
            else
            {
                Node ex = this.head;
                this.head = this.head.next;
                ex.next = null;
                this.size--;
                return ex;
            }
        }

        public Node? RemoveIndex(int index)
        {
            if (index <= 0) return RemoveFirst();
            else if(index > 0 && index < this.size)
            {
                // Get Node oluşturulduktan sonra doldurulacak
                Node temp = GetNode(index - 1);
                Node ex = temp.next!;
                temp.next = ex.next;
                ex.next = null;
                this.size--;
                return ex;
            }
            return null;
        }

        public Node GetNode(int index)
        {
            if(index >= 0 && index < this.size)
            {
                Node? temp = this.head;
                for(int i = 0; i < index; i++)
                {
                    temp = temp!.next;
                }
                return temp!;
            }
            return null!;
        }

        public void SetNode(int index, int data)
        {
            Node temp = GetNode(index);
            if(temp != null)
            {
                temp.data = data;
            }
        }

    }
}
