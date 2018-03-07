using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsAndQueues
{
    public class SinglyLinkedList
    {
        public void GetLinkedList(LinkedList<string> linked, string newData)
        { 
            linked.AddLast("one");
            linked.AddLast("two");
            linked.AddLast("three");

            // Insert a node before the second node (after the first node)

            LinkedListNode<string> node = linked.Find("one");
            linked.AddAfter(node, "inserted");

            foreach (var value in linked)
            {
                Console.WriteLine(value);
            }
        }
    }
}
