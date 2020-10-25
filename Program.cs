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
            linkedListclass.InsertLast(30);
            linkedListclass.InsertLast(70);
            ///Inserting in middle
            linkedListclass.InsertAfterElement(30,40);
            linkedListclass.Display();
            linkedListclass.DeleteNode(40);
            linkedListclass.Display();
            int count = linkedListclass.Size();
            Console.WriteLine("\nsize of list:"+count);

            
            
            
        }
    }
}