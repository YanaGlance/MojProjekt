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
