using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.classes
{
    internal class LinkedListe<T> where T : IComparable<T>
    {
        private Node<T>? head;
        private Node<T>? tail;
        private int size;
        public int Size { get { return size; } }
        public Node<T>? Head { get { return head; } }
        public Node<T>? Tail { get { return tail; } }

        public LinkedListe()
        {
            this.head = null;
            this.tail = null;
            this.size = 0;
        }
        public LinkedListe(T data)
        {
            Node<T> newNode = new Node<T>(data);
            this.head = newNode;
            this.tail = newNode;
            this.size = 1;
        }

        public void Append(T data)
        {
            Node<T> newNode = new Node<T>(data);
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
            Node<T>? temp = this.head;

            while(temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
            Console.WriteLine("--------------");
        }

        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);
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

        public void Insert(int index,T data)
        {
            if(index <= 0) AddFirst(data);

            else if(index >= 0 && index < this.size)
            {
                Node<T> newNode = new Node<T>(data);
                Node<T> temp = GetNode(index - 1);
                newNode.next = temp.next;
                temp.next = newNode;
                this.size++;
            }

            else
            { 
                Append(data);
            }
           
        }

        public Node<T>? RemoveLast()
        {
            if(this.size == 0) return null;
            Node<T>? temp = this.head;
            Node<T>? last = this.tail;
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

        public Node<T>? RemoveFirst()
        {
            if(this.head ==  null) return null;

            else if(this.size == 1)
            {
                Node<T>? ex = this.head;
                this.head = null;
                this.tail = null;
                this.size--;
                return ex;
            }
            else
            {
                Node<T> ex = this.head;
                this.head = this.head.next;
                ex.next = null;
                this.size--;
                return ex;
            }
        }

        public Node<T>? RemoveIndex(int index)
        {
            if (index <= 0) return RemoveFirst();
            else if(index > 0 && index < this.size)
            {
                // Get Node oluşturulduktan sonra doldurulacak
                Node<T> temp = GetNode(index - 1);
                Node<T> ex = temp.next!;
                temp.next = ex.next;
                ex.next = null;
                this.size--;
                return ex;
            }
            return null;
        }

        public Node<T> GetNode(int index)
        {
            if(index >= 0 && index < this.size)
            {
                Node<T>? temp = this.head;
                for(int i = 0; i < index; i++)
                {
                    temp = temp!.next;
                }
                return temp!;
            }
            return null!;
        }

        public void SetNode(int index,T data)
        {
            Node<T> temp = GetNode(index);
            if(temp != null)
            {
                temp.data = data;
            }
        }

        public void Clear()
        {
            this.head = null;
            this.tail = null;
            this.size = 0;
        }

        public void Reverse()
        {
            Node<T>? prev = null;
            Node<T>? current = this.head;
            Node<T>? next = null;
            this.tail = this.head;
            while(current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            this.head = prev;
        }

        public void InsertArraySorted(T[] values)
        {
            foreach (T val in values)
            {
                Node<T> newNode = new Node<T>(val);

                // 1. DURUM: Liste boşsa VEYA Head'deki data, gelen datadan büyük veya eşitse
                // (head.Data >= val) mantığı CompareTo ile yapılır:
                // Sonuç >= 0 ise head daha büyük demektir.
                if (head == null || head.data?.CompareTo(val) >= 0)
                {
                    newNode.next = head;
                    head = newNode;
                }
                else
                {
                    // 2. DURUM: Araya veya sona ekleme
                    Node<T> current = head;

                    // Sonraki düğüm var olduğu sürece VE
                    // sonraki düğümün verisi bizim verimizden KÜÇÜK olduğu sürece ilerle.
                    // (current.Next.Data < val) => CompareTo < 0
                    while (current.next != null && current.next.data?.CompareTo(val) < 0)
                    {
                        current = current.next;
                    }

                    // Doğru yeri bulduk (current -> newNode -> current.Next)
                    newNode.next = current.next;
                    current.next = newNode;
                }
            }
        }

    }
}
