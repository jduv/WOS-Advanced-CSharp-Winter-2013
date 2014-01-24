namespace Examples.EmployeeDatabase
{
    using System.Collections.Generic;

    public enum SortOrder
    {
        AlphabeticalByFirstName,
        AlphabeticalByLastName,
        BySalary,
        JobTitle,
        Age
    }

    public interface IEmployeeDatabase
    {
        #region Properties

        IEnumerable<Employee> Employees { get; }

        Employee HighestSalariedEmployee { get; }

        #endregion

        #region Methods

        IEnumerable<Employee> GetEmployeesBySortOrder(SortOrder order);

        void Add(Employee toAdd);

        void Remove(int id);

        Employee Get(int id);

        #endregion
    }
}
