using System;
using System.Collections;


namespace Day7Collections
{
    class HashTableEx
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add(101, "vivek");
            ht.Add(5, "vikas");
            ht.Add(103, "ajay");
            foreach(DictionaryEntry dt in ht)
            {
                Console.WriteLine("key is {0} and Value is {1} ",dt.Key,dt.Value);
               
            }


           SortedList st = new SortedList();
            st.Add(101, "vivek");
            st.Add(5, "vikas");
            st.Add(103, "ajay");
            foreach (DictionaryEntry dt in st)
            {
                Console.WriteLine("key is {0} and Value is {1} ", dt.Key, dt.Value);

            }
            Console.Read();
        }
    }
}
