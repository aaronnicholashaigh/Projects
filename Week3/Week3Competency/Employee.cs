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

      //default constructor
      public Employee ()
      {
          lastName = null;
          firstName = null; 
          employeeType = '0';
      }
      
      //constructor that passes values
      public Employee (string aLastName, string aFirstName, char aEmployeeType)
      {
          lastName = aLastName;
          firstName = aFirstName;
          employeeType = aEmployeeType;
      }

      //get/set for employee last name
      public string getEmployeeLastName()
      {
          return lastName;
      }

      public void setEmployeeLastName( string anotherLastName)
      {
        lastName = anotherLastName;
      }

      //Calculate bonus 
      int employeeBonus = 0;

      //Create my polymorphism. Use ToString Method.
      public override string ToString ()
      {
          return firstName + ", " + lastName + " is an " + employeeType + " employee. Their bonus is: " + employeeBonus + ".";
      }

    
  }
} 

