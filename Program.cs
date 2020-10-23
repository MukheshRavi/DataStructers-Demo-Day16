using System;

namespace DataStructuresDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListclass linkedListclass = new LinkedListclass();
            ///inserting at front
            linkedListclass.InsertFront(70);
            linkedListclass.InsertFront(30);
            linkedListclass.InsertFront(56);
            linkedListclass.Display();
        }
    }
}