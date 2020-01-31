using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Collections
{
    class Person
    {
       public int age;
        public Person(int age)
        {
            this.age = age;
        }
        public int Get_age()
        {
            return age;
        }
    }

    class Professor:Person
    {
        string title;
        public Professor(int age ,string title):base(age)
        {
            this.title = title;
        }
        public void teach()
        {
            Console.WriteLine("my age is {0} and i teach {1} ",,age,title);
        }

    }

    class Students:Person
    {
      int id;
        string name;
        public Students(string name,int age, int id) : base(age)
        {
            this.id = id;
            this.name = name;
        }
        public void StudentDetails()
        {
            Console.WriteLine("My name is {0} and I am {1} old and my id is {2} ",name,age,id);

            //float Get_gpa()
            //{
            //    return 100.00f;
            //}
        }
    }
    class Assignment
    {
        static void Main()
        {

            Console.WriteLine("Enter name, age and Id of student");
            string name = Console.ReadLine();
            int age = Convert.ToInt32( Console.ReadLine());
              int id = Convert.ToInt32( Console.ReadLine());

            Students studentObj = new Students(name,age,id);
            Console.WriteLine(studentObj.Get_age());
            studentObj.StudentDetails();


            Console.WriteLine("Enter the age and subject of professor");
            int Professorage = Convert.ToInt32(Console.ReadLine());
            string Subject = Console.ReadLine();

           Professor ProfessorObj = new Professor(Professorage,Subject);
            ProfessorObj.teach();
            Console.Read();
        }
    }
}
