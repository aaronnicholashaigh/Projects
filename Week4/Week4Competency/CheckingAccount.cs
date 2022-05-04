using System;

namespace Week4Competency
{
  class CheckingAccount : BankAccount 
  {
      public double AnnualFee
      { get; set; }

      //Default constructor 
      public CheckingAccount ()
      {
          AnnualFee = 0.0;
      }

      //Constructor with parameters
      public CheckingAccount (int newAccountID, string newTypeofAccount, double newCurrentBalance, double newAnnualFee) : base(newAccountID, newTypeofAccount, newCurrentBalance)
      {
          AnnualFee = newAnnualFee;
      }

      //Withdrawal Method
      public override double WithdrawalAbstract (double withdrawalAmount)
      {
          CurrentBalance = CurrentBalance - withdrawalAmount;
          return CurrentBalance;
      }

      public override string ToString ()
      {
          return base.ToString() + " | Annual Fee: " + AnnualFee;
      }
  }
}