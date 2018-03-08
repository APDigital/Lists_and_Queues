using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            //Single Linked List
            SinglyLinkedList singleList = new SinglyLinkedList();
            singleList.AddToLinkedList("A");
            singleList.AddToLinkedList("B");
            singleList.AddToLinkedList("C");
            singleList.AddToLinkedList("D");
            singleList.AddToLinkedList("E");

            singleList.DisplayAllItems();
            Console.ReadLine();

            //Double Linked List
            DoubleLinkedList list = new DoubleLinkedList();
            list.Insert("A");
            list.Insert("B");
            list.Insert("C");

            DoubleLink link4 = list.Insert("D");
            list.Insert("E");
            Console.WriteLine("List: " + list);

            list.InsertAfter(link4, "[4a]");
            Console.WriteLine("List: " + list);
            Console.Read();
        }
    }
}
