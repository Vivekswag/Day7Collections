using System;
using System.Collections.Generic;


namespace Day7Collections
{
    public class Student2
    {
        public int Total<T>(T Maths,T Science ,T Hindi)
        {
            var m = Maths;
            dynamic s = Science;
            dynamic h = Hindi;
            return m + s + h;
        }
    }
    class Generic2
    {
        static void Main()
        {
            Student2  student = new Student2();
            Console.WriteLine(student.Total<int>(20,20,20));
            Console.Read();
        }
    }
}
