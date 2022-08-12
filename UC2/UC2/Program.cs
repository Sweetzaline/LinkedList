using System;
namespace UC2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LinkedList");
            LinkedList List = new LinkedList();
            List.Add(70);
            List.Add(30);
            List.Add(56);
            List.Display();
        }
    }
}