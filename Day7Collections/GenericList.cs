using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Collections
{
    class Student
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
        public Student(int Sid,string Sname)
        {
            this.Sid=Sid;
            this.Sname = Sname;

        }
    }
    class GenericList
    {
        static void Main()
        {
            List<string> lt = new List<string>();
            lt.Add("Vivek");
            lt.Add("Vikas");
            lt.Add("Ajay");
            foreach(var item in lt)
            {
                Console.WriteLine(item);
            }


            List<Student> stu = new List<Student>();
            stu.Add(new Student(101, "Anamika"));
            stu.Add(new Student(102, "Anju"));
            stu.Add(new Student(103, "komal"));
            foreach (Student item in stu)
            {
                Console.WriteLine(item.Sid+" "+item.Sname);
            }
            Console.Read();
        }
    }
}
