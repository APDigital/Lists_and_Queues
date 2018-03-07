using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsAndQueues
{
    class SinglyLinkedList
    {
        public class Node
        {
            public Node next = null;
            public string data;
        }
        private Node root = null;
        public Node First { get { return root; } }
        public Node Last
        {
            get
            {
                Node curr = root;
                if (curr == null)
                {
                    return null;

                }
                while (curr.next != null)
                {
                    curr = curr.next;
                }
                return curr;
            }
        }
        public void Append(string value)
        {
            Node n = new Node { data = value };
            if (root == null)
                root = n;
            else
                Last.next = n;
        }
        public void Delete(Node n)
        {
            if (root != null)
            {
                root = n.next;
                n.next = null;
            }
            else
            {
                Node curr = root;
                while (curr.next != null)
                {
                    if (curr.next == n)
                    {
                        curr.next = n.next;
                        n.next = null;
                        break;
                    }
                    curr = curr.next;
                }
            }
        }
    }
}
