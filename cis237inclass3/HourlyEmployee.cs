using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class HourlyEmployee : Employee
    {
        //*****************************
        //Variable / Backing fields
        //*****************************
        private decimal hourlyRate;
        private decimal hoursPerWeek;

        //*****************************
        //Properties
        //*****************************
        //This will be a property to get the Yearly Salary of the employee
        public decimal Salary
        {
            get
            {
                return this.hourlyRate * WEEKS_PER_YEAR * hoursPerWeek;
            }
        }

        //******************************
        //Public Methods
        //******************************

        public override string ToString()
        {
            //Make a call to the parent class's version of ToString
            //to get the first and last name part of the string.
            //Then concat it to the salary
            return base.ToString() + " " + Salary.ToString("C");
        }

        public override string GetFormattedSalary()
        {
            return (this.hoursPerWeek*this.hourlyRate) + "*" +
                WEEKS_PER_YEAR + " = " + Salary.ToString("C");
        }

        //This is the clone method that we had to write an implementation for
        //because it is declared abstract in our parent class, which is also
        //declared in the parents interface that it implements.
        public override object Clone()
        {
            return new HourlyEmployee(this.FirstName, this.LastName, this.hoursPerWeek, this.hourlyRate);
        }



        //*****************************
        //Constructors
        //*****************************
        //Declare a 4 parameter constructor that takes everything that we need
        //in. It then calls the parent constructor to have the parent take care
        //of assigning the passed in first and last name variables.
        //This is done by adding : base(param1, param2) after the constructor
        //definition
        public HourlyEmployee(string FirstName, string LastName,
                            decimal HoursPerWeek, decimal HourlyRate) :
                            base(FirstName, LastName)
        {
            this.hoursPerWeek = HoursPerWeek;
            this.hourlyRate = HourlyRate;
        }
    }
}
