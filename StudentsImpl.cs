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
