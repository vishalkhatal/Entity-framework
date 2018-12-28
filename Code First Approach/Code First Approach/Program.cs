using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Approach
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentContext db = new StudentContext();
            var students = db.students.ToList();
            var departments = db.departments.ToList();

        }

    }
}
