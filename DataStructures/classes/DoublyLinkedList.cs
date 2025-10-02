using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.classes
{
    internal class DoublyLinkedList <T>
    {
        private DoublyNode<T>? head;
        private DoublyNode<T>? tail;
        private int size;

        public DoublyLinkedList()
        {
            this.head = null;
            this.tail = null;
            this.size = 0;
        }

        public DoublyLinkedList(T data)
        {
            DoublyNode<T> newNode = new DoublyNode<T>(data);
            this.head = newNode;
            this.tail = newNode;
            this.size = 1;
        }
    }
}
