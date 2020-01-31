using System;
using System.Collections;

namespace Day7Collections
{
    class ArrayListEx
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            ArrayList al1 = new ArrayList();
            Console.WriteLine("Capacity is " + al.Capacity);
            al.Add(10);
            Console.WriteLine("Capacity is " + al.Capacity);
            al.Add(20);
            al.Add(30);
            al.Add(40);
            al.Add(50);
            al.Add(" ");
            al.Add(null);
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(al.Contains(20));
            //al.CopyTo(al1);
            Console.WriteLine(al.GetType());
           // Console.WriteLine(al.);
            Console.WriteLine("Count is "+ al.Count);
            Console.WriteLine("capacity is " + al.Capacity);
            Console.Read();


        }
    }
}
