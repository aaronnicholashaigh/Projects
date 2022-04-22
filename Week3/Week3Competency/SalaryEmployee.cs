using System;

namespace MyApplication
{
  class Salary : Employee 
  {
      public int salaryPay
      { get; set; }
 

      //default constructor
      public Salary ()
      {
          salaryPay = -1;
      }
      
      //constructor that passes values
      public Salary (int aSalaryPay, string aFirstName, string aLastName, char aEmployeeType): base(aFirstName, aLastName, aEmployeeType)
      {
          salaryPay = aSalaryPay;
      }
      
      //Calculate bonus 
        public int SalaryBonusMethod ()
        {
            double doubleSalaryPay = (double) salaryPay;
            double doubleSalaryBonus = doubleSalaryPay * .1;
            int intSalaryBonus = (int) doubleSalaryBonus;

            return intSalaryBonus;
        }

      public override string ToString ()
      {
          return firstName + " " + getEmployeeLastName() + " is an " + employeeType + " employee. Their bonus is: " + SalaryBonusMethod() + ".";
      }
  }
}