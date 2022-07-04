using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Tables
{
    public class Node<gtype>
    {
        public Node<gtype> next;
        public gtype data;
        public Node(gtype data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
