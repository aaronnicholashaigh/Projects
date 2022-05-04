using System;

namespace Week4Competency
{
  class Program
  {
    static double GetValidDouble (double lowValue)
    {
        double value;
        do 
        {
            Console.WriteLine("Please enter a value greater than " + lowValue);
            value = Convert.ToInt32(Console.ReadLine());
        } while (value < lowValue);
        return value;

    }
    static void Main(string[] args)
    {
        bool userChoice;
        string userChoiceString;

        List<BankAccount> bankAccountList = new List<BankAccount>();


        //Default account info
        bankAccountList.Add(new SavingsAccount(9000, "Savings Account", 1000, .10));
        bankAccountList.Add(new CheckingAccount(8000, "Checking Account", 2000, 25));
        bankAccountList.Add(new CDAccount(7000, "CD Account", 3000, .10, 30));
        

        //Main Loop
        do
        {

            //user input and validation loop
            do
            {
                userChoice = false;

                Console.WriteLine("Please select an option: ");
                Console.WriteLine("A: Display your accounts. ");
                Console.WriteLine("D: Deposit. ");
                Console.WriteLine("W: Withdraw. ");
                Console.WriteLine("Q: Quit.");

                userChoiceString = Console.ReadLine();

                userChoice = (userChoiceString == "A" || userChoiceString == "a" ||
                            userChoiceString == "D" || userChoiceString == "d" ||
                            userChoiceString == "W" || userChoiceString == "w" ||
                            userChoiceString == "Q" || userChoiceString == "q" );
                
                if (!userChoice)
                {
                    Console.WriteLine("Please enter a valid option. ");
                }
            } while (!userChoice);

            //Display Accounts
            if (userChoiceString == "A" || userChoiceString == "a")
            {
                for (int index = 0; index < bankAccountList.Count; index ++)
                {
                    Console.WriteLine(bankAccountList[index]);
                }
            }

            //Deposit
            else if (userChoiceString == "D" || userChoiceString == "d")
            { 
                Console.WriteLine("Account number?");
                int depositAccountNumber = Convert.ToInt32(Console.ReadLine());


                //default for account not found
                bool accountFound = false;

                //find a valid account ID
                for (int index = 0; index < bankAccountList.Count; index ++)
                {
                    if (bankAccountList[index].AccountID == depositAccountNumber)
                    {
                        accountFound = true; 
                        Console.WriteLine("How much would you like to deposit?");
                        double depositAmount = GetValidDouble(0);
                        bankAccountList[index].CurrentBalance = bankAccountList[index].DepositMethod(depositAmount);
                        Console.WriteLine("The amount has been deposited. Your new balance is: $" + bankAccountList[index].CurrentBalance);
                    }
                }
                if (accountFound == false)
                {
                    Console.WriteLine("The account number was not found.");
                }
            }

            //Withdraw
            else if (userChoiceString == "W" || userChoiceString == "w")
            {
                Console.WriteLine("Account Number?");
                int withdrawAccountNumber = Convert.ToInt32(Console.ReadLine());

                //default for account not found
                bool accountFound = false;

                //find a valid account ID
                for (int index = 0; index < bankAccountList.Count; index ++)
                {
                    if (bankAccountList[index].AccountID == withdrawAccountNumber)
                    {
                        accountFound = true; 

                        //Savings Account
                        if (bankAccountList[index].TypeOfAccount == "Savings Account")
                        {
                            double withdrawSavingsAmount;
                            do
                            {
                                Console.WriteLine("Withdrawal amount?");
                                withdrawSavingsAmount = GetValidDouble(0);
                                if (bankAccountList[index].CurrentBalance <= withdrawSavingsAmount)
                                {
                                    Console.WriteLine("Insufficient funds. Enter a new amount.");
                                }
                            }
                            while (bankAccountList[index].CurrentBalance <= withdrawSavingsAmount);
                            bankAccountList[index].CurrentBalance = bankAccountList[index].WithdrawalAbstract(withdrawSavingsAmount);

                            Console.WriteLine("The amount has been withdrawn. Your new balance is: $" + bankAccountList[index].CurrentBalance);

                        }

                        //Checking Account
                        else if (bankAccountList[index].TypeOfAccount == "Checking Account")
                        {
                            double withdrawCheckingAmount;
                            do
                            {
                            Console.WriteLine("Withdrawal amount");
                            withdrawCheckingAmount = GetValidDouble(0);
                            if (withdrawCheckingAmount > (bankAccountList[index].CurrentBalance / 2))
                            {
                                Console.WriteLine("Insufficient funds. Enter a new amount.");
                            }
                            }
                            while (withdrawCheckingAmount > (bankAccountList[index].CurrentBalance / 2));
                            bankAccountList[index].CurrentBalance = bankAccountList[index].WithdrawalAbstract(withdrawCheckingAmount);
                            Console.WriteLine("The amount has been withdrawn. Your new balance is: $" + bankAccountList[index].CurrentBalance);
                        }

                        //CD Account
                        else
                        {
                            double withdrawCDAmount;
                            do
                            {
                                Console.WriteLine("Withdrawal amount");
                                withdrawCDAmount = GetValidDouble(0);
                               
                                if (bankAccountList[index].CurrentBalance < bankAccountList[index].SetPenaltyPlusWithdrawal(withdrawCDAmount))
                                {
                                    Console.WriteLine("Insufficient funds. Enter a new amount.");
                                }
                            } while (bankAccountList[index].CurrentBalance < bankAccountList[index].SetPenaltyPlusWithdrawal(withdrawCDAmount));
                            bankAccountList[index].CurrentBalance = bankAccountList[index].WithdrawalAbstract(withdrawCDAmount);
                            Console.WriteLine("The amount has been withdrawn. Your new balance is: $" + bankAccountList[index].CurrentBalance);
                        }
                    }
                }
                if (accountFound == false)
                {
                    Console.WriteLine("Account number not found.");
                }
            } 

            //Quit
            else 
            {
                Console.WriteLine("Goodbye");
            }

        } while (!(userChoiceString == "Q" || userChoiceString == "q"));
    }
  }
}