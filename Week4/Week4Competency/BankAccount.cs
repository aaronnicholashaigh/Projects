using System;

namespace Week4Competency
{
  abstract class BankAccount : ISetPenalty      //Base account
  {
    public int AccountID
    { get; set; }

    public string TypeOfAccount
    { get; set; }

    public double CurrentBalance
    { get; set; }

    //Default constructor
    public BankAccount ()
    {
        AccountID = 0;
        TypeOfAccount = "";
        CurrentBalance = 0.0;
    }

    //Constructor with parameters
    public BankAccount (int newAccountID, string newTypeofAccount, double newCurrentBalance)
    {
        AccountID = newAccountID;
        TypeOfAccount = newTypeofAccount;
        CurrentBalance = newCurrentBalance;
    }

    //Deposit Method
    public double DepositMethod(double depositAmount)
    {
        CurrentBalance = CurrentBalance + depositAmount;
        return CurrentBalance;
    }

    //Withdrawal Method
    public abstract double WithdrawalAbstract(double withdrawalAmount); //this does not have a body because it's an abstract method

    public virtual double SetPenaltyPlusWithdrawal (double newPenalty)
    {
        return 0;
    }

    public override string ToString()
    {
        return "Account ID: " + AccountID + " | Type of Account: " + TypeOfAccount + " | Current Balance: " + CurrentBalance;
    }
  }
}