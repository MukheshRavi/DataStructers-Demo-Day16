using System;

namespace DataStructuresDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListclass<int> linkedListclass = new LinkedListclass<int>();
            ///Inserting at last
            linkedListclass.InsertLast(56);
            linkedListclass.InsertLast(70);
            ///Inserting in middle
            linkedListclass.InsertInMiddle(30);
            linkedListclass.Display();
            linkedListclass.DeleteLastNode();
            linkedListclass.Display();
            int pos=linkedListclass.Search(30);
            Console.WriteLine("Found at podition" + pos);
            
            
        }
    }
}