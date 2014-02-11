using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeCampus
{
    class StudentEnrollment
    {
        //static void MyStudent(IStudent newStudent)
        //{
        //    Console.WriteLine("Your Student info is " + newStudent);
        //}
        static void Main(string[] args)
        {
            Student newKid = new Student("John", "Thomas", 7318);
            Console.WriteLine(newKid);
            Console.ReadLine();

        }
    }
}
