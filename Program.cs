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
