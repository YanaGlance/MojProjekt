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
