using System;
namespace UC1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LinkedList");
            LinkedList List = new LinkedList();
            List.Add(56);
            List.Add(30);
            List.Add(70);
            List.Display();
        }
    }
    public class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
        }
    }
    public class LinkedList
    {
        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0}, insterted into Linked List", node.data);
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Empty LinkedList");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }   
}
