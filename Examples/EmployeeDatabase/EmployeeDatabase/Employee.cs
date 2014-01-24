namespace Examples.EmployeeDatabase
{
    public class Employee
    {
        #region Fields & Constants

        private int id;
        private string firstName;
        private string lastName;
        private int age;
        private string description;
        private int salary;

        #endregion

        #region Constructors & Destructors

        public Employee(int id, string aFirstName, string aLastName, int anAge, string aDescription, int aSalary)
        {
            this.id = id;
            this.firstName = aFirstName;
            this.lastName = aLastName;
            this.age = anAge;
            this.description = aDescription;
            this.salary = aSalary;
        }

        #endregion

        #region Properties

        public int Id
        {
            get
            {
                return this.id;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
        }

        public int Salary
        {
            get
            {
                return this.salary;
            }
        }

        public string JobTitle
        {
            get
            {
                return this.description;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
        }

        #endregion
    }
}
