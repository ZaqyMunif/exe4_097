using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe4_097
{
    class Node
    {
        public string info;
        public Node next;
        public Node(string i, Node n)
        {
            info = i;
            next = n;
        }
    }
    class Stacks
    {
        Node top;
        public Stacks()
        {
            top = null;
        }
        bool empty()
        {
            if (top == null)
                return (true);
            else
                return (false);
        }
        public void push(string element)
        {
            Node zaqy;
            zaqy = new Node(element, null);
            zaqy.next = top;
            top = zaqy;
            Console.WriteLine("\n" + element + "pushed. ");
        }
        public void pop()
        {
            Console.WriteLine("\nThe popped element is: " + top.info);
            top = top.next;
        }
        public void display()
        {

        }
        static void Main(string[] args)
        {
        }
    }
}
