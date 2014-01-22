using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Examples.EmployeeDatabase.UnitTests
{
    using System.Linq;

    [TestClass]
    public class TextFileBasedEmployeeDatabaseUnitTests
    {
        private string TestEmployees = "1,Jeremy,Duvall,31,Consultant,50000" + System.Environment.NewLine +
            "2,Mark,Yorrick,24,Consultant,55000" + System.Environment.NewLine +
            "3,John,Thomas,37,Entrepenur,25000" + System.Environment.NewLine +
            "4,James,Pennie,34,Photographer,65000" + System.Environment.NewLine +
            "5,David,Sinclair,31,Criminal Mastermind,150000";

        [TestMethod]
        public void Ctor_WithValidLines()
        {
            var target = new TextFileBasedEmployeeDatabase(TestEmployees);
            Assert.AreEqual(5, target.Employees.Count());
        }

        [TestMethod]
        public void Prop_MaxSalariedEmployee_ReturnsCorrectEmployee()
        {
            var target = new TextFileBasedEmployeeDatabase(TestEmployees);
            Assert.AreEqual(150000, target.HighestSalariedEmployee.Salary);
        }
    }
}
