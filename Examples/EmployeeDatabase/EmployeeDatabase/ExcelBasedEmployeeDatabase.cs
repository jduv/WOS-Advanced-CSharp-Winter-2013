using IndexML.Spreadsheet;
using System.Collections.Generic;
using System.IO;
namespace Examples.EmployeeDatabase
{
    public class ExcelBasedEmployeeDatabase : IEmployeeDatabase
    {
        #region Fields & Constants

        public IList<Employee> list;

        #endregion

        #region Constructors & Destructors

        public ExcelBasedEmployeeDatabase(string path)
        {
            if (File.Exists(path))
            {
                using (var indexer = new SpreadsheetIndexer(File.OpenRead(path)))
                {

                }
            }
            else
            {
                throw new FileNotFoundException("File not found!");
            }
        }

        #endregion

        #region Properties

        public IEnumerable<Employee> Employees
        {
            get { throw new System.NotImplementedException(); }
        }

        public Employee HighestSalariedEmployee
        {
            get { throw new System.NotImplementedException(); }
        }

        #endregion

        #region Public Methods

        public IEnumerable<Employee> GetEmployeesBySortOrder(SortOrder order)
        {
            throw new System.NotImplementedException();
        }

        public void Add(Employee toAdd)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new System.NotImplementedException();
        }

        public Employee Get(int id)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
