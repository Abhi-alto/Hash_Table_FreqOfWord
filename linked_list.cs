using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Tables
{
    internal class linked_list<gtype> where gtype : IComparable
    {
        public Node<gtype> head;
        public void create(gtype a)               //creating a node with data
        {
            Node<gtype> node = new Node<gtype>(a);
            this.head = node;
            Console.WriteLine("Node created with " + head.data);
        }
        public void add(gtype b)                  //adding node in the beginning
        {
            Node<gtype> node = new Node<gtype>(b);
            Node<gtype> temp = head;
            if (temp == null)
            {
                this.head = node;
                Console.WriteLine("Node created with " + head.data);
            }
            else
            {
                temp.next = head.next;
                head = node;
                head.next = temp;
                Console.WriteLine("Node added with data " + head.data);
            }
        }
        public void append(gtype a)           //adding nodes to the end
        {
            Node<gtype> node = new Node<gtype>(a);
            Node<gtype> temp = head;
            if (temp == null)
            {
                Console.WriteLine("List is empty");
                head = node;
                Console.WriteLine("Node appended with data " + head.data);
            }
            else
            {
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                Console.WriteLine("Node appended with data " + temp.next.data);
            }
        }
        public void delete(gtype deleteNode, int position)             //deleting node at a particular position
        {
            Node<gtype> node = new Node<gtype>(deleteNode);
            Node<gtype> temp = head;
            int posi = 1;
            if (head == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            else if(position==1)
            {
                head = head.next;
            }
            else
            {
                while (posi != (position - 1))
                {
                    temp = temp.next;
                    posi++;
                }
                temp.next = temp.next.next;
            }
        }
        public void insert(gtype inser, int position)              //adding nodes to a particular position
        {
            Node<gtype> node = new Node<gtype>(inser);
            Node<gtype> temp = head;
            int posi = 1;
            if (position < 1)
            {
                Console.WriteLine("Wrong position");
            }
            else if (position == 1)
            {
                Node<gtype> newNode = node;
                newNode.next = temp;
                head = newNode;
                Console.WriteLine("Inserted new node with data " + newNode.data);
            }
            else
            {
                while (posi != position - 1)
                {
                    temp = temp.next;
                    posi++;
                }
                Node<gtype> newNode = node;
                newNode.next = temp.next;
                temp.next = newNode;
                Console.WriteLine("Inserted new node with data " + newNode.data);
            }
        }
        public int search(gtype find)            //searching for a particular node
        {
            Node<gtype> node = new Node<gtype>(find);
            Node<gtype> temp = head;
            int position = 1;
            bool present = true;
            if (head == null)                  //if there is no node
            {
                return 0;
            }
            else
            {
                while (temp.data.CompareTo(find) != 0)
                {
                    if (temp.next == null)                  //if we are at the last node
                    {
                        present = false;
                        break;
                    }
                    temp = temp.next;
                    position++;
                }
                if (present)
                {
                    return position;
                }
                else
                    return 0;
            }
        }
        public int size()                   //for getting size of the linked list
        {
            Node<gtype> temp = head;
            int size = 0;
            while (temp != null)
            {
                temp = temp.next;
                size++;
            }
            return size;
        }
        public int frequency(gtype data)                    //to get frequency of a string
        {
            Node<gtype> node = new Node<gtype>(data);
            Node<gtype> temp = head;
            int counter = 0;
            while(temp!=null)
            {
                if((temp.data.CompareTo(data)) != null)                 //compares each node data with the data to be found
                {
                    counter++;
                }
                temp = temp.next;
            }return counter;
        }
        public void print()                //printing the nodes
        {
            Node<gtype> temp = this.head;
            if (temp != null)
            {
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Linked list empty now");
            }
        }
    }
}
