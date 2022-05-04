using System;

namespace MyApplication
{
  class Employee
  {
      private string lastName;
      

      public string firstName
      { get; set; }

      public char employeeType
      { get; set; }

      //Create my default constructor
      public Employee ()
      {
          lastName = null;
          firstName = null; 
          employeeType = '\0';
      }
      
      //Create my constructor that passes values
      public Employee (string aLastName, string aFirstName, char aEmployeeType)
      {
          lastName = aLastName;
          firstName = aFirstName;
          employeeType = aEmployeeType;
      }

      //Create a get/set methods for employee lastName
      public string getEmployeeLastName()
      {
          return lastName;
      }

      public void setEmployeeLastName( string anotherLastName)
      {
        lastName = anotherLastName;
      }

      
      //Calculate the bonus 
      int employeeBonus = 0;

      //Create my polymorphism. Use ToString Method.
      public override string ToString ()
      {
          return firstName + " " + lastName + " is an " + employeeType + " employee. Their bonus will be: " + employeeBonus + ".";
      }
  }
}
