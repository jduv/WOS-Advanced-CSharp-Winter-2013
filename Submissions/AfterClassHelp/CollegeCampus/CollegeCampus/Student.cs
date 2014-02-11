using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeCampus
{
    class Student : IStudent
    {



        string firstName;
        string lastName;
        int studentId;

        public Student(){
            firstName = "";
            lastName = "";
            studentId = 0;


        }

        public Student(String first, String last, int idnumber)
        {
            this.firstName = first;
            this.lastName = last;
            this.studentId = idnumber;
        }
        public string fName
        {
            get
            {
                return fName;

            }
            set
            {
                this.fName = firstName;

            }
        }

        public string lName
        {
            get
            {
                return lName;
            }
            set
            {
                this.lName = lastName;
            }
        }

        public int id
        {
            get
            {
                return id;
            }
            set
            {
                if (id > 0)
                this.id = studentId;
                else{
                Console.Error.WriteLine("The Student ID number must be greater than 0");
                Console.Error.WriteLine("Please Start Over");
                }

            

                
            }
        }
    }
}
