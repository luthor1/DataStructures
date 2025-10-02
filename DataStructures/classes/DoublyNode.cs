using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.classes 
{
    internal class DoublyNode <T>
    {
        public T? data { get; set; }
        public DoublyNode<T>? next { get; set; }
        public DoublyNode<T>? prev { get; set; }
        public DoublyNode (T data)
        {
            this.data = data;
            this.next = null;
            this.prev = null;
        }
    }
}
