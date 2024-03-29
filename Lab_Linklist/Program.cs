using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Linklist
{
    public class SinglyLinkedList
    {
        static void Main(string[] args)
        {
            LinkedList<string> nodes = new LinkedList<string>();
            nodes.AddLast("Joe Blow");
            nodes.AddLast("Joe Schmoe");
            nodes.AddLast("John Smith");
            nodes.AddLast("Jane Doe");
            nodes.AddLast("Bob Bobberson");
            nodes.AddLast("Sam Sammerson");
            nodes.AddLast("Dave Daverson");

            Console.WriteLine("Linked List Contains:");
            foreach (var node in nodes)
            {
                Console.WriteLine(node);
            }

            Console.WriteLine();
            if (nodes.Count > 0)
            {
                nodes.RemoveFirst();
                nodes.RemoveLast();
            }

            Console.WriteLine("\nLinked List Contents After Removing First and Last:");
            foreach (var node in nodes)
            {
                Console.WriteLine(node);
            }

            Console.ReadLine();
        }
    }
}

