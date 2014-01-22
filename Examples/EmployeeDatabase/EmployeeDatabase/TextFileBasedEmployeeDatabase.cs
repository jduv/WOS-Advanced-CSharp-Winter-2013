namespace Examples.EmployeeDatabase
{
    using System;
    using System.Collections.Generic;

    public class TextFileBasedEmployeeDatabase : IEmployeeDatabase
    {
        #region Fields & Constants

        private IList<Employee> list = new List<Employee>();

        #endregion

        #region Constructors & Destructors

        public TextFileBasedEmployeeDatabase(string lines)
        {
            var employeeLines = lines.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in employeeLines)
            {
                int id = 0;
                int salary = 0;
                int age = 0;
                string firstName = null;
                string lastName = null;
                string jobDescription = null;
                bool succeeded = true;

                var employeeFields = line.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < employeeFields.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            succeeded = int.TryParse(employeeFields[i], out id);
                            break;
                        case 1:
                            firstName = employeeFields[i];
                            break;
                        case 2:
                            lastName = employeeFields[i];
                            break;
                        case 3:
                            succeeded = int.TryParse(employeeFields[i], out age);
                            break;
                        case 4:
                            jobDescription = employeeFields[i];
                            break;
                        case 5:
                            succeeded = int.TryParse(employeeFields[i], out salary);
                            break;
                        default:
                            throw new Exception("Sorry, your file is corrupt");
                    }
                }

                var employee = new Employee(id, firstName, lastName, age, jobDescription, salary);
                this.list.Add(employee);
            }
        }

        #endregion

        #region Properties

        public IEnumerable<Employee> Employees
        {
            get
            {
                return this.list;
            }
        }

        public Employee HighestSalariedEmployee
        {
            get
            {
                Employee maxSalariedEmployee = null;
                foreach (var employee in this.list)
                {
                    if (maxSalariedEmployee == null)
                    {
                        maxSalariedEmployee = employee;
                    }

                    if (employee.Salary > maxSalariedEmployee.Salary)
                    {
                        maxSalariedEmployee = employee;
                    }
                }

                return maxSalariedEmployee;
            }
        }

        #endregion

        #region Methods

        public IEnumerable<Employee> GetEmployeesBySortOrder(SortOrder order)
        {
            throw new System.NotImplementedException();
        }

        public void Add(Employee toAdd)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(Employee toRemove)
        {
            throw new System.NotImplementedException();
        }

        public void Get(int id)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
