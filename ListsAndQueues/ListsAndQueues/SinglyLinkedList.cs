using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsAndQueues
{
    class SinglyLinkedList
    {
        public Node First { get; set; }
        public Node Last { get; set; }

        public void AddToLinkedList(string value)
        {
            Node node = new Node();
            node.Value = value;

            if (First == null)
            {
                First = node;
                Last = node;
            }
            else
            {
                Last.Next = node;
                Last = node;
            }
        }
        public void DisplayAllItems()
        {
            Node current = First;
            Console.WriteLine("List: ");
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }

        public class Node
        {
            public string Value { get; set; }
            public Node Next { get; set; }

        }
    }
}
