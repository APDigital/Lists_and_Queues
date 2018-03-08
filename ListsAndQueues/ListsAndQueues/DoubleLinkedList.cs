using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsAndQueues
{
    public class DoubleLinkedList
    {
        private DoubleLink _first;
        public bool IsEmpty
        {
            get
            {
                return _first == null;
            }
        }
        public DoubleLinkedList()
        {
            _first = null;
        }
        public DoubleLink Insert(string title)
        {
            // Creates a link
            DoubleLink link = new DoubleLink(title);
            //makes it the first item in the list
            link.NextLink = _first;

            if (_first != null)
                _first.PreviousLink = link;
            _first = link;
            return link;
        }
        public DoubleLink Delete()
        {
            DoubleLink f = _first;
            if (_first != null)
            {
                _first = _first.NextLink;
                if (_first != null)
                    _first.PreviousLink = null;
            }
            return f;
        }
        public override string ToString()
        {
            DoubleLink currentLink = _first;
            StringBuilder builder = new StringBuilder();
            while (currentLink != null)
            {
                builder.Append(currentLink);
                currentLink = currentLink.NextLink;
            }
            return builder.ToString();
        }
        public void InsertAfter(DoubleLink link, string title)
        {
            if (link == null || string.IsNullOrEmpty(title))
                return;
            DoubleLink newLink = new DoubleLink(title);
            newLink.PreviousLink = link;
            // Update the 'after' link's next reference, so its previous points to the new one
            if (link.NextLink != null)
                link.NextLink.PreviousLink = newLink;
            // Steal the next link of the node, and set the after so it links to our new one
            newLink.NextLink = link.NextLink;
            link.NextLink = newLink;
        }
    }
}
