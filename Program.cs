using System;

namespace DataStructuresDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListclass linkedListclass = new LinkedListclass();
            ///Inserting at last
            linkedListclass.InsertLast(56);
            linkedListclass.InsertLast(30);
            linkedListclass.InsertLast(70);
            linkedListclass.Display();
            
        }
    }
}