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

