using System;

namespace Week4Competency
{
  class SavingsAccount : BankAccount, IAnnualEarnings
  {
      public double AnnualInterestRate
      { get; set; }

      //Default constructor 
      public SavingsAccount () : base ()
      {
          AnnualInterestRate = 0.0;
      }

      //Constructor with Parameters
      public SavingsAccount (int newAccountID, string newTypeofAccount, double newCurrentBalance, double newAnnualInterestRate) : base (newAccountID, newTypeofAccount, newCurrentBalance)
      {
          AnnualInterestRate = newAnnualInterestRate;
      }

      //Withdrawal method
      public override double WithdrawalAbstract(double withdrawalAmount)
      {   
        CurrentBalance = CurrentBalance - withdrawalAmount;
        return CurrentBalance;
      }

      //Interface 
      public double AnnualEarnings()
      {
          return CurrentBalance * AnnualInterestRate;
      }

      public override string ToString()
      {
          return base.ToString() + " | Annual Interest: $" + AnnualInterestRate + " | Annual Earnings from interest: $" + AnnualEarnings();   
      }
  }
}