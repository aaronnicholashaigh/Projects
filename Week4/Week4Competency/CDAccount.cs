using System;

namespace Week4Competency
{
  class CDAccount : BankAccount, IAnnualEarnings, ISetPenalty
  {
      public double AnnualInterestRate
      { get; set; }

      public double PenaltyEarlyWithdrawal
      { get; set; }

      //Default constructor 
      public CDAccount ()
      {
          AnnualInterestRate = 0.0;
          PenaltyEarlyWithdrawal = 0.0;
      }

      //Constructor with parameters
      public CDAccount (int newAccountID, string newTypeofAccount, double newCurrentBalance, double newAnnualInterestRate, double newPenaltyEarlyWithdrawal) : base (newAccountID, newTypeofAccount, newCurrentBalance)
      {
          AnnualInterestRate = newAnnualInterestRate;
          PenaltyEarlyWithdrawal = newPenaltyEarlyWithdrawal;
      }

      //Withdraw along with penalty amount
      public double TotalWithdrawal(double withdrawlandPenalty)
      {
          return withdrawlandPenalty + PenaltyEarlyWithdrawal;
      } 

      //Withdrawal Method
      public override double WithdrawalAbstract(double withdrawalAmount)
      {    
          double totalWithdrawal = withdrawalAmount + PenaltyEarlyWithdrawal;
          CurrentBalance = CurrentBalance - totalWithdrawal;
          return CurrentBalance;
      }

      //Interface method
      public double AnnualEarnings()
      {
          return CurrentBalance * AnnualInterestRate;
      }
      
     public override double SetPenaltyPlusWithdrawal( double newPenalty )
     {
         return PenaltyEarlyWithdrawal + newPenalty;
     }

      public override string ToString()
      {
          return base.ToString() + " | Annual Interest: $" + AnnualInterestRate + " | Penalty for early withdrawal: $" + PenaltyEarlyWithdrawal + " | Annual earnings from interest: $" + AnnualEarnings();   
      }
  }
}