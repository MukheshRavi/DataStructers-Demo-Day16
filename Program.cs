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
            linkedListclass.DeleteFirstNode();
            linkedListclass.Display();
            
        }
    }
}