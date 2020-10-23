using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresDemo
{
   public class LinkedListclass
    {
        public Node head;
        /// <summary>
        /// UC1
        /// Inserts at last of link
        /// </summary>
        /// <param name="new_data">The new data.</param>
        public void InsertLast(int new_data)
        {
            ///creating new Node
            Node new_node = new Node(new_data);
            if (this.head == null)
                this.head = new_node;
            else
            {
                Node lastNode = GetLastNode();
                ///adds new element to the last node
                lastNode.next = new_node;
            }
            Console.WriteLine("Insert into list " + new_node.data);
        }
        /// <summary>
        /// This method returns the last node
        /// </summary>
        /// <returns></returns>
        public Node GetLastNode()
        {
            ///returns last node by iterating full list
            Node temp = this.head;
            while (temp.next != null)
                temp = temp.next;
            ///next will be null for last node
            return temp;
        }
        public void InsertFront(int new_data)
        {
            ///We will create a new node. The next of the new node will point to the head of the Linked list.
            Node new_node = new Node(new_data);
            /// When we want to add any node at the front, we want the head to point to it.
            new_node.next = this.head;
            ///The previous Head node is now the second node of Linked List because the new node is added at the front.
            this.head = new_node;

            Console.WriteLine("inserted into list " + new_node.data);
        }
        /// <summary>
        /// This method displays full list
        /// </summary>
        public void Display()
        {
            Node temp = this.head;
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

