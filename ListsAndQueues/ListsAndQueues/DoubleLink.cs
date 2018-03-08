using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsAndQueues
{
    public class DoubleLink
    {
        public string Title { get; set; }
        public DoubleLink PreviousLink { get; set; }
        public DoubleLink NextLink { get; set; }

        public DoubleLink(string title)
        {
            Title = title;
        }
        public override string ToString()
        {
            return Title;
        }
    }
}
