using System;

namespace MyApplication
{
  class Hourly : Employee
  {
      public float HourlyPay
      { get; set; }
 

      //Create my default constructor
      public Hourly ()
      {
          HourlyPay = 0.0f;
      }
      
      //Create my constructor that passes values
      public Hourly (float aHourlyPay, string aFirstName, string aLastName, char aEmployeeType): base(aFirstName, aLastName, aEmployeeType)
      {
          HourlyPay = aHourlyPay;
      }
      
      //Calculate the bonus 
        public int HourlyBonusMethod ()
        {
            double doubleHourlyPay = (double) HourlyPay;
            double doubleHourlyBonus = doubleHourlyPay * 80;
            int intHourlyBonus = (int) doubleHourlyBonus;

            return intHourlyBonus;
        }

      //Create my polymorphism. Use ToString Method.
      public override string ToString ()
      {
          return firstName + " " + getEmployeeLastName() + " is an " + employeeType + " employee. Their bonus will be: " + HourlyBonusMethod() + ".";
      }
  }
}