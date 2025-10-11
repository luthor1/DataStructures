using DataStructures.classes;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region LinkedList
            //// Liste Olusturuldu Append ile sona eleman eklendi
            //Console.WriteLine("Liste olusturuldu");
            //var myList = new LinkedListe<int>(10);
            //myList.Append(10);
            //myList.Append(20);
            //myList.Append(30);
            //myList.Append(40);
            //myList.Print();

            //// Basa eleman eklendi
            //Console.WriteLine("Basa eleman eklendi");
            //myList.AddFirst(5);
            //myList.Print();

            //// Indekse gore eleman eklendi
            //Console.WriteLine("Araya eleman eklendi");
            //myList.Insert(2, 99);
            //myList.Print();

            //// Son eleman silindi
            //Console.WriteLine("Son eleman silindi");
            //myList.RemoveLast();
            //myList.Print();

            //// Ilk eleman silindi
            //Console.WriteLine("Ilk eleman silindi");
            //myList.RemoveFirst();
            //myList.Print();

            //// Indekse gore eleman silindi
            //Console.WriteLine("Aradan eleman silindi");
            //myList.RemoveIndex(1);
            //myList.Print();

            //// Get ile indekse gore eleman getirildi
            //Console.WriteLine("Indekse gore eleman getirildi");
            //Node<int>? node = myList.GetNode(1);
            //if (node != null) Console.WriteLine(node.data);
            //Console.WriteLine("--------------");

            //// Set ile indekse gore eleman guncellendi
            //Console.WriteLine("Indekse gore eleman guncellendi");
            //myList.SetNode(1, 55);
            //myList.Print();

            //// Get ler kullanildi
            //Console.WriteLine("Get ler kullanildi");
            //Console.WriteLine("Head = " + myList.Head?.data);
            //Console.WriteLine("Tail = " + myList.Tail?.data);
            //Console.WriteLine("Size = " + myList.Size);
            //Console.WriteLine("--------------");




            //var mylist = new LinkedListe<object>();
            //mylist.Append("Ali");
            //mylist.Append("Veli");
            //mylist.Append("Ayse");
            //mylist.Append(12);
            //int a = (int)mylist.GetNode(3).data!;
            //mylist.Print();
            //Console.WriteLine(a * 13);

            #endregion

            #region DoublyLinkedList

            var myDoublyList = new DoublyLinkedList<int>(10);
            myDoublyList.Append(20);
            myDoublyList.Append(30);
            myDoublyList.Append(40);
            myDoublyList.AddFirst(99);
            myDoublyList.Print();

            #endregion





        }
    }
}
