using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structure
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Student[] emp = { new  Student(),

                       new  Student(),

                       new  Student() };





            emp[0].SetStudent(1, "moulali", 20);

            emp[1].SetStudent(2, "apsar", 21);

            emp[2].SetStudent(3, "nagendra", 23);




            emp[0].DisplayStudent();

            emp[1].DisplayStudent();

            emp[2].DisplayStudent();

        }
    }


}


