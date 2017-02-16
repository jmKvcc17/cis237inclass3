using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    //This is an abstract class. It is made abstract by adding the 'abstract'
    //keyword before the word class. Abstract classes can not be instanciated.
    //The primary use for them is to provide functionality that child classes
    //can use, and extend from.
    public abstract class Employee : IEmployee //Implement IEmployee
    {
        //Const for weeks per year
        protected const decimal WEEKS_PER_YEAR = 52;

        //*****************************
        //Variable / Backing fields
        //*****************************
        private string firstName;
        private string lastName;

        //*****************************
        //Properties
        //*****************************
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        //******************************
        //Public Methods
        //******************************
        private string FirstAndLastName()
        {
            return firstName + " " + lastName;
        }

        public override string ToString()
        {
            return FirstAndLastName();
        }

        //An abstract method MUST have no method body. Hence the ; at the end.
        //An abstract method MUST be overidden in all child classes.
        //We made this method abstract because based on the information that
        //this class has, we have no idea how to calculate a salary, let
        //alone format one.
        //Declaring it abstract leaves the implementation details to the child
        //class to figure out.
        public abstract string GetFormattedSalary();

        //A virtual method MUST have a method body, even if it is empty.
        //A virtual method CAN be overridden in child classes, but is not
        //required to be.
        //We made this method virtual because we already have all of the
        //needed information to provide a method body. We simply left it
        //virtual in case a subclass would like to override it for some reason.
        public virtual string GetLastNameFirstName()
        {
            return this.lastName + ", " + this.firstName;
        }

        //This method is declared in the IClonable interface that IEmployee implements
        //since we implment IEmployee, and IEmployee implments IClonable, we have to
        //provide an implementation to the methods listed in IClonable. The only
        //method declared there is "Clone" (This method). Since we don't know how
        //to clone our children, and we can't instanciate Employee due to it being
        //abstract, we declare this method as abstract, and push the work of making
        //the implementation down to the child class to figure out. 
        public abstract object Clone();

        //*****************************
        //Constructors
        //*****************************
        public Employee(string FirstName, string LastName)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
        }
    }
}
