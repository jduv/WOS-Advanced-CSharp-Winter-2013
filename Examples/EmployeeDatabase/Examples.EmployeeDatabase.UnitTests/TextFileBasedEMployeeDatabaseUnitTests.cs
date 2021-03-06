﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Examples.EmployeeDatabase.UnitTests
{
    using System;
    using System.Linq;

    [TestClass]
    public class TextFileBasedEmployeeDatabaseUnitTests
    {
        private string TestEmployees = "1,Jeremy,Duvall,31,Consultant,50000" + System.Environment.NewLine +
            "2,Mark,Yorrick,24,Consultant,55000" + System.Environment.NewLine +
            "3,John,Thomas,37,Entrepenur,25000" + System.Environment.NewLine +
            "4,James,Pennie,34,Photographer,65000" + System.Environment.NewLine +
            "5,David,Sinclair,31,Criminal Mastermind,150000";

        private string IdenticalIds = "1,James,Pennie,34,Photographer,65000" + System.Environment.NewLine +
            "1,David,Sinclair,31,Criminal Mastermind,150000";

        [TestMethod]
        public void Ctor_WithValidLines()
        {
            var objectWeAreTesting = new TextFileBasedEmployeeDatabase(TestEmployees);
            Assert.AreEqual(5, objectWeAreTesting.Employees.Count());
        }

        [TestMethod]
        public void Prop_MaxSalariedEmployee_ReturnsCorrectEmployee()
        {
            var objectWeAreTesting = new TextFileBasedEmployeeDatabase(TestEmployees);
            Assert.AreEqual(150000, objectWeAreTesting.HighestSalariedEmployee.Salary);
        }

        [ExpectedException(typeof(InvalidOperationException))]
        [TestMethod]
        public void Remove_IdenticalIds_ThrowsException()
        {
            var objectWeAreTesting = new TextFileBasedEmployeeDatabase(IdenticalIds);
            objectWeAreTesting.Remove(1);
        }


        [TestMethod]
        public void SortOrder_FirstName_HasCorrectOrder()
        {
            var objectWeAreTesting = new TextFileBasedEmployeeDatabase(TestEmployees);
            var resultList = objectWeAreTesting.GetEmployeesBySortOrder(SortOrder.AlphabeticalByFirstName);

            String firstName = String.Compare("David",1,"David",5);

            foreach (var employee in resultList)
            {
                Assert.IsTrue(firstName = employee.FirstName);
                firstName = employee.FirstName;
            }


        [TestMethod]
        public void SortOrder_BySalary_HasCorrectOrder()
        {
            var objectWeAreTesting = new TextFileBasedEmployeeDatabase(TestEmployees);
            var resultList = objectWeAreTesting.GetEmployeesBySortOrder(SortOrder.BySalary);

            int lastSalary = int.MaxValue;
            foreach (var employee in resultList)
            {
                Assert.IsTrue(lastSalary >= employee.Salary);
                lastSalary = employee.Salary;
            }
          

        }
    }
}
