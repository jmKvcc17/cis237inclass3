using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using cis237inclass3;

namespace cis237inclass3UnitTest
{
    [TestClass] // Decoration
    public class SalaryEmployeeUnitTest
    {
        [TestMethod]
        public void LastNameFirstNameTest()
        {
            // Arrange
            SalaryEmployee salaryEmployee = new SalaryEmployee("David", "Barnes", 250m);

            string expected = "Barnes, David";

            // Act
            string actual = salaryEmployee.GetLastNameFirstName();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetYearlySalaryTest()
        {
            SalaryEmployee salaryEmployee = new SalaryEmployee("David", "Barnes", 250m);
            string expected = "$250.00";
            string actual = salaryEmployee.GetFormattedSalary();

            Assert.AreEqual(expected, actual);
        }
    }
}
