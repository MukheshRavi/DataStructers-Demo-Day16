using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresDemo
{
   public class LinkedListclass<T>
    {
        public Node<T> head;
        /// <summary>
        /// UC1 and UC3
        /// Inserts at last of link
        /// </summary>
        /// <param name="new_data">The new data.</param>
        public void InsertLast(T new_data)
        {
            ///creating new Node
            Node<T> new_node = new Node<T>(new_data);
            if (this.head == null)
                this.head = new_node;
            else
            {
                Node<T> lastNode = GetLastNode();
                ///adds new element to the last node
                lastNode.next = new_node;
            }
            Console.WriteLine("Insert into list " + new_node.data);
        }
        /// <summary>
        /// This method returns the last node
        /// </summary>
        /// <returns></returns>
        public Node<T> GetLastNode()
        {
            ///returns last node by iterating full list
            Node<T> temp = this.head;
            while (temp.next != null)
                temp = temp.next;
            ///next will be null for last node
            return temp;
        }
        public void InsertFront(T new_data)
        {
            ///We will create a new node. The next of the new node will point to the head of the Linked list.
            Node<T> new_node = new Node<T>(new_data);
            /// When we want to add any node at the front, we want the head to point to it.
            new_node.next = this.head;
            ///The previous Head node is now the second node of Linked List because the new node is added at the front.
            this.head = new_node;

            Console.WriteLine("inserted into list " + new_node.data);
        }
        public void InsertInMiddle(T item)
        {
            ///Creating new node 
            Node<T> temp = this.head;
            Node<T> newNode = new Node<T>(item);
            ///Inserting in between by changing links
            newNode.next = temp.next;
            temp.next = newNode;
            head = temp;
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
                while (temp != null)
                {
                    Console.Write(" " + temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}

