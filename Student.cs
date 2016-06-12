using System;
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
