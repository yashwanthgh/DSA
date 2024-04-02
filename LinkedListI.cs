using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAImplementation
{
    public class LinkedListI
    {
        private Node? head;

        public void Add(int data)
        {
            Node node = new()
            {
                Data = data
            };
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node current = head;
                while(current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = node;
            }
           
        }

        public void Print()
        {
            Node node = head;
            while (node != null)
            {
                Console.Write(node.Data+" ");
                node = node.Next;
            }
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            LinkedListI instance = new LinkedListI();
            instance.Add(56);
            instance.Add(30);
            instance.Add(70);
            instance.Print();   
        }
    }
}
