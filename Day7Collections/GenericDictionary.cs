using System;
using System.Collections.Generic;


namespace Day7Collections
{
    class GenericDictionary
    {
        static void Main()
        {
            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt.Add(1, "Ritu");
            dt.Add(2, "Karan");
            dt.Add(3, "Chudail");
            foreach(KeyValuePair<int,string> k in dt)
            {
                Console.WriteLine(k.Key+" "+k.Value);
            }
            Console.Read();
        }
    }
}
