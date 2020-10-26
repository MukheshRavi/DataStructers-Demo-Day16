using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresDemo
{
    class OrderedLinkedList<T> where T:IComparable
    {
        public Node<T> head;
        public void Add(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (this.head == null)
                this.head = newNode;
            else
            {
                T current = this.head.data;
                int value = current.CompareTo(item);
                if(value>0)
                {
                    newNode.next = this.head;
                    this.head = newNode;
                }
                else
                {
                    Node<T> temp = this.head;

                    while (temp.next != null && (temp.next.data.CompareTo(item)<0))
                    {
                        temp = temp.next;
                    }
                    if (temp.next != null)
                    {
                        newNode.next = temp.next;
                        temp.next = newNode;
                    }
                    else
                    {
                        temp.next=newNode;
                        newNode.next = null;
                    }
                }
            }
        }
        /// <summary>
        /// This method displays full list
        /// </summary>
        public void Display()
        {
            Node<T> temp = this.head;
            ///If head is null then linked list is empty
            if (temp == null)
            {
                Console.WriteLine("Linked is empty");
                return;
            }
            else
            {
                ///Iterates full list and displays data in each node
                Console.WriteLine(" ");
                while (temp != null)
                {
                    Console.Write(" " + temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}
