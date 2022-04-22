using System;

namespace MyApplication
{
  class Hourly : Employee
  {
      public float hourlyPay
      { get; set; }
 

      //default constructor
      public Hourly ()
      {
          hourlyPay = 0.0f;
      }
      
      //constructor that passes values
      public Hourly (float aHourlyPay, string aFirstName, string aLastName, char aEmployeeType): base(aFirstName, aLastName, aEmployeeType)
      {
          hourlyPay = aHourlyPay;
      }
      
      //Calculate bonus 
        public int HourlyBonusMethod ()
        {
            double doubleHourlyPay = (double) hourlyPay;
            double doubleHourlyBonus = doubleHourlyPay * 80;
            int intHourlyBonus = (int) doubleHourlyBonus;

            return intHourlyBonus;
        }

      public override string ToString ()
      {
          return firstName + " " + getEmployeeLastName() + " is an " + employeeType + " employee. Their bonus is: " + HourlyBonusMethod() + ".";
      }
  }
}