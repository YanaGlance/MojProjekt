using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Person
    {
        public string name;
        public string surname;
        public string dateOfBirth;
        public string gender;

        public Person(string name, string surname, string dateOfBirth, string gender)
        {
            this.name = name;
            this.surname = surname;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
        }
    }
}

sing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Student : Person
    {

        public string indexNumber;

        public Student(string name, string surname, string dateOfBirth, string gender, string indexNumber) : base(name, surname, dateOfBirth, gender)
        {
            this.name = name;
            this.surname = surname;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
            this.indexNumber = indexNumber;
        }

        public override string ToString()
        {
            return base.ToString() + " Student [name=" + name + ", surname=" + surname
                + ", date of birth=" + dateOfBirth + ", gender=" + gender + "index Number=" + indexNumber + "]";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    interface Students
    {
        List<Student> getStudentInfo(string name, string surname, string dateOfBirth, string gender, string indexNumber);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class StudentsImpl : Students
    {
        List<Student> students = new List<Student>();

        public void StudentsList()
        {
            students.Add(new Student("Jan", "Kowalski", "1988", "M", "12345"));
            students.Add(new Student("Agnieszka", "Nowak", "1991", "F", "12456"));
            students.Add(new Student("Jadwiga", "Korbut", "1965", "F", "12567"));
            students.Add(new Student("Michal", "Malinowski", "1972", "M", "12678"));
            students.Add(new Student("Tomasz", "Mickiewicz", "1983", "M", "12789"));

            foreach (Student c in students)
            {
                Console.WriteLine("Name: " + c.name);
                Console.WriteLine("Surname: " + c.surname);
                Console.WriteLine("Date of Birth: " + c.dateOfBirth);
                Console.WriteLine("Gender: " + c.gender);
                Console.WriteLine("Index Number: " + c.indexNumber);
            }
        }
        public List<Student> getStudentInfo(string name, string surname, string dateOfBirth,
            string gender, string indexNumber)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Program
    {
        static void Main(string[] args)
        {

            Boolean quit = false;
            StudentsImpl student = new StudentsImpl();

            do
            {
                Console.WriteLine("Choose the number");
                Console.WriteLine("1. Show all students");
                Console.WriteLine("2. Exit");

                int choice;
                choice = int.Parse(Console.ReadLine());

                StudentsImpl students = new StudentsImpl();

                switch (choice)
                {
                    case 1:
                        {
                            student.StudentsList();
                            break;
                        }
                    case 2:
                        {
                            quit = true;
                            Console.WriteLine("Bye. See you soon");
                            break;
                        }
                }
                Console.ReadKey();
            } while (!quit);
        }
    }
}
