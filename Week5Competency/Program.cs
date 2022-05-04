using System;
using System.Collections.Generic;
namespace CustomerMemberships
{
	class Program
  {
	static string userMenuOptions () 
    {
		//print menu options
		Console.WriteLine("");
		Console.WriteLine("Select a Menu Option:");
		Console.WriteLine("   C: Add a new membership.");
		Console.WriteLine("   R: Read and print a list of all memberships.");
		Console.WriteLine("   U: Update a memberhip.");
		Console.WriteLine("   D: Delete a membership.");
		Console.WriteLine("   L: List all the memberships");
		Console.WriteLine("   P: Make a purchase.");
		Console.WriteLine("   T: reTurn an item.");
		Console.WriteLine("   A: Apply cashback rewards.");
		Console.WriteLine("   Q: Quit the program.");

		return Console.ReadLine().ToUpper();
	}
		
		//ask member id; make sure it's unique
		//for CREATE and UPDATE
	static int askForUniqueMemberId(string question, List<Membership> membList, bool trueOrFalse) 
    {
		bool firstPass = true; 
		int memberId;
		bool validate = false;

		do 
        {
			//print 'oops' statement if not first runthru
			if (firstPass == false) 
            {
				Console.WriteLine("Oops! Incorrect User input. Try again.");
			}

			firstPass = false;

			//get user input and validate
			Console.WriteLine(question);
			memberId = Convert.ToInt32(Console.ReadLine());
			validate = ValidateInput(memberId, membList);
		} while (validate != trueOrFalse); //end do/while

		return memberId;
	}

	//validate unique member id
	//FOR askForUniqueMemberId
    static bool ValidateInput(int memberId, List<Membership> membList) 
    {
		//initalize variable (0 = false; 1 = true)
		bool isMembIdUnique = true;

		foreach(Membership aMembership in membList) 
        {
			if (memberId == aMembership.MembershipId) 
            {
				isMembIdUnique = false;
			}
		}
		return isMembIdUnique;
    }

		//validate user input (lo and hi)
    static bool ValidateInput(double userInput, int low, int high = int.MaxValue) 
    {
		//if incorrect   
        if (userInput <= low || userInput > high) 
        {
			return false;
        } 

        //if correct
        else 
        {
            return true;
        }
    }

	static double askForValidMoneyAmount(string question, int low) 
    {
		bool firstPass = true; 
		double moneyAmount;
		bool validate = false;

		do 
        {
			//print 'oops' statement if not first runthru
			if (firstPass == false) 
            {
				Console.WriteLine("Oops! Incorrect User input. Try again.");
			}

			firstPass = false;

			//get user input and validate
			Console.WriteLine(question);
			moneyAmount = Convert.ToDouble(Console.ReadLine());
			validate = ValidateInput(moneyAmount, low);
		} while (validate != true); //end do/while

		return moneyAmount;
	}

	static void Main(string[] args)
    {
		bool userChoice;
		string userChoiceString;

		//initialize cash back percentages for each different membership type
		//to be used when applying cashback
		double regularPercent = 5;
		double executivePercent = 3.5;
		double nonProfitPercent = 6;
		double corporatePercent = 10;
			
		//create list of memberships
		List<Membership> memberships = new List<Membership>();

		//add a series of hard-coded membership types
		memberships.Add(new Executive(1, "email1@gmail.com", "Executive", 100.00, 999.99, executivePercent));
		memberships.Add(new NonProfit(2, "email2@gmail.com", "NonProfit", 25.00, 50.00, nonProfitPercent));
		memberships.Add(new Corporate(3, "email3@gmail.com", "Corporate", 274.99, 10000.00, corporatePercent));
		memberships.Add(new Executive(4, "email4@gmail.com", "Executive", 100.00, 989.59, executivePercent));
		memberships.Add(new NonProfit(5, "email5@gmail.com", "NonProfit", 30.00, 1062.00, nonProfitPercent));
		memberships.Add(new Corporate(6, "email6@gmail.com", "Corporate", 174.99, 1984.00, corporatePercent));

		//repeat till user quits
		do 
        {
			//get valid user input
			do 
            {
				//initialize variable
				userChoice = false;

				//provide the user a list of menu options
				//get valid user input
				userChoiceString = userMenuOptions();

				//valid user choices
				userChoice = (userChoiceString == "C" || 
							    userChoiceString == "R" || 
								userChoiceString == "U" || 
								userChoiceString == "D" || 
								userChoiceString == "L" || 
								userChoiceString == "P" || 
								userChoiceString == "T" || 
								userChoiceString == "A" || 
								userChoiceString == "Q"
			);

			//validity check
			if (!userChoice) 
            {
				Console.WriteLine("Oops! Please enter a valid menu option");
			}

		} while (!userChoice);

				
				//if C (create)

				//if R (print)

				//if U (update)

				//if D (delete)

				//if L (list)

				//if P (purchase)

				//if T (return)

				//if A (cashback)

				//if Q (quit)
				
        
    }
  }
}