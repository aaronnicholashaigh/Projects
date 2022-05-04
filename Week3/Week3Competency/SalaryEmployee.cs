using System;

namespace MyApplication
{
  class Salary : Employee 
  {
      public int SalaryPay
      { get; set; }
 

      //Create my default constructor
      public Salary ()
      {
          SalaryPay = -1;
      }
      
      //Create my constructor that passes values
      public Salary (int aSalaryPay, string aFirstName, string aLastName, char aEmployeeType): base(aFirstName, aLastName, aEmployeeType)
      {
          SalaryPay = aSalaryPay;
      }
      
      //Calculate the bonus 
        public int SalaryBonusMethod ()
        {
            double doubleSalaryPay = (double) SalaryPay;
            double doubleSalaryBonus = doubleSalaryPay * .1;
            int intSalaryBonus = (int) doubleSalaryBonus;

            return intSalaryBonus;
        }

      //Create my polymorphism. Use ToString Method.
      public override string ToString ()
      {
          return firstName + " " + getEmployeeLastName() + " is an " + employeeType + " employee. Their bonus will be: " + SalaryBonusMethod() + ".";
      }
  } 
}