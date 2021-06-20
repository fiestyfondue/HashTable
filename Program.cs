using HashTable;
using System;
using System.Collections;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementation of Hashtables using LinkedList");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "Be");
            hash.Add("2", "Or");
            hash.Add("3", "Not");
            hash.Add("4", "To");
            hash.Add("5", "Be");

            string hash5 = hash.Get("5");
            Console.WriteLine("5th index value is : " + hash5);
            string hash2 = hash.Get("2");
            Console.WriteLine("2nd index value is: "+hash2);
            
        }
    }
}
  