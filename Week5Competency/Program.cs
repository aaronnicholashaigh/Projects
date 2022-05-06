using System;
using System.Collections.Generic; //needed for lists

namespace CustomerMemberships
{
	class Program
  {
	static string askUserMenuOptions () 
	{
		Console.WriteLine("");
		Console.WriteLine("Select a Menu Option:");
		Console.WriteLine("   C: Add a new membership.");
		Console.WriteLine("   R: Read and print a list of all memberships.");
		Console.WriteLine("   U: Update a memberhip.");
		Console.WriteLine("   D: Delete a membership.");
		Console.WriteLine("   L: List all of the memberships.");
		Console.WriteLine("   P: Make a purchase.");
		Console.WriteLine("   T: Return an item.");
		Console.WriteLine("   A: Apply cashback rewards.");
		Console.WriteLine("   Q: Quit the program.");

		return Console.ReadLine().ToUpper();
	}
		
	//for create and update options
	static int askForUniqueMemberId(string question, List<Membership> membList, bool trueOrFalse) 
	{
		bool firstPass = true; 
		int memberId;
		bool validate = false;

		do 
		{
			if (firstPass == false) 
			{
				Console.WriteLine("Incorrect input.  Try again.");
			}
			
			firstPass = false;

			//get user input and validate
			Console.WriteLine(question);
			memberId = Convert.ToInt32(Console.ReadLine());
			validate = ValidateInput(memberId, membList);
		} while (validate != trueOrFalse);

		return memberId;
	}

    static bool ValidateInput(int memberId, List<Membership> membList) 
	{
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
		//incorrect  
        if (userInput <= low || userInput > high) 
		{
			return false;
        } 

        //correct
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
			if (firstPass == false) 
			{
				Console.WriteLine("Incorrect input.  Try again.");
			}

			firstPass = false;

			//get user input and validate
			Console.WriteLine(question);
			moneyAmount = Convert.ToDouble(Console.ReadLine());
			validate = ValidateInput(moneyAmount, low);
		} while (validate != true);

		return moneyAmount;
	}

	static void Main(string[] args)
    {
		bool userChoice;
		string userChoiceString;

		//initilize amounts for each membership level
		double regularPercent = 5;
		double executivePercent = 3.5;
		double nonProfitPercent = 6;
		double corporatePercent = 10;
			
		List<Membership> memberships = new List<Membership>();

		memberships.Add(new Regular(1, "email@yahoo.com", "Regular", 99.99, 500.00, regularPercent));
		memberships.Add(new Executive(2, "email2@yahoo.com", "Executive", 200.00, 999.00, executivePercent));
		memberships.Add(new NonProfit(3, "email3@yahoo.com", "NonProfit", 50.00, 250.00, nonProfitPercent));
		memberships.Add(new Corporate(4, "email4@yahoo.com", "Corporate", 274.95, 25000.00, corporatePercent));
		memberships.Add(new Regular(5, "email5@yahoo.com", "Regular", 99.99, 675.00, regularPercent));
		memberships.Add(new Executive(6, "email6@yahoo.com", "Executive", 200.00, 1059.55, executivePercent));
		memberships.Add(new NonProfit(7, "email7@yahoo.com", "NonProfit", 50.00, 2097.00, nonProfitPercent));
		memberships.Add(new Corporate(8, "email8@yahoo.com", "Corporate", 274.95, 1066.00, corporatePercent));


		//main program loop
		do 
		{
			do 
			{
				userChoice = false;

				userChoiceString = askUserMenuOptions();

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
					
				if (!userChoice) 
				{
					Console.WriteLine("Incorrect input.  Try again.");
				}
			} while (!userChoice);

			//C - Create
			if (userChoiceString == "C") 
			{
				Console.WriteLine("Create a new membership:");

				string idQuestion = "Enter a unique Member ID:";
				int memberId = askForUniqueMemberId(idQuestion, memberships, true);

				Console.WriteLine("Enter their email address:");
				string email = Console.ReadLine();

				Console.WriteLine("Enter the membership type (R, E, NP, C):");
				string memberType = (Console.ReadLine()).ToUpper();

				Console.WriteLine("Enter annual cost:");
				double cost = Convert.ToDouble(Console.ReadLine());

				Console.WriteLine("Enter month's running purchase total:");
				double monthlyPurcase = Convert.ToDouble(Console.ReadLine());

				switch (memberType) 
				{
					case "R": 
						memberships.Add(new Regular(memberId, email, "Regular", cost, monthlyPurcase, regularPercent));
						break;

					case "E": 
						memberships.Add(new Executive(memberId, email, "Executive", cost, monthlyPurcase, executivePercent));
						break;

					case "NP": 
						memberships.Add(new NonProfit(memberId, email, "NonProfit", cost, monthlyPurcase, nonProfitPercent));
						break;

					case "C": 
						memberships.Add(new Corporate (memberId, email, "Corporate", cost, monthlyPurcase, corporatePercent));
						break;

						default: 
						
						Console.WriteLine("Incorrect entry.  Not added.");
						break;
				}

				Console.WriteLine($"Member {memberId} successfully created.");
			}

			//R Read/Print
			else if (userChoiceString == "R") 
			{
				Console.WriteLine("Read list:");

				foreach(Membership aMembership in memberships) 
				{
					Console.WriteLine(aMembership);
				}
			}

			//U - Update
			else if (userChoiceString == "U") 
			{
				Console.WriteLine("Update membership:");

				//find existing member id
				string updateQuestion = "Enter existing Membership ID to update:";
				int memberId = askForUniqueMemberId(updateQuestion, memberships, false);

				Console.WriteLine("Update email address.");
				string newEmail = Console.ReadLine();

				foreach(Membership aMember in memberships) 
				{
					if (aMember.MembershipId == memberId) 
					{
						aMember.Email = newEmail;
					}
				}

				Console.WriteLine($"Member {memberId} successfully updated.");
			}

			//D - Delete
			else if (userChoiceString == "D") 
			{
				Console.WriteLine("Delete membership:");

				//find existing member id; keep asking till user enters existing id
				string updateQuestion = "Enter existing Membership ID to delete:";
				int memberId = askForUniqueMemberId(updateQuestion, memberships, false);

				//are you sure?
				Console.WriteLine($"Confirm (Y / N)");
				string confirmation = (Console.ReadLine()).ToUpper();

				bool removed = false;

				if (confirmation == "Y") 
				{
					//remove from list
					for (int i = 0; i < memberships.Count; i++) 
					{
						if (memberships[i].MembershipId == memberId) 
						{
							memberships.RemoveAt(i);
							removed = true;
						}
					}
				}

				//report results to user
				if (removed == true) 
				{
					Console.WriteLine($"Member {memberId} deleted.");
				} 

				else 

				{
					Console.WriteLine("Cancelled.");
				}

			}

			//L - List
			else if (userChoiceString == "L") 
			{
				Console.WriteLine("List all members:");

				foreach(Membership aMembership in memberships) 
				{
					Console.WriteLine(aMembership);
				}
			}

			//P - Make a purchase
			else if (userChoiceString == "P") 
			{
				Console.WriteLine("Make a purchase:");

				//find existing member id
				string purchaseQuestion = "Enter existing Membership ID to apply a purchase to:";
				int memberId = askForUniqueMemberId(purchaseQuestion, memberships, false);

				//enter purchase amount; must be greater than $0.00
				int low = 0;
				string moneyQuestion = $"Enter purchase amount: (> ${low}.00)";
				double purchaseAmount = askForValidMoneyAmount(moneyQuestion, low);

				foreach(Membership aMember in memberships) 
				{
					if (aMember.MembershipId == memberId) 
					{
						aMember.MonthlyPurchaseTotal += purchaseAmount;
					}
				}

				Console.WriteLine($"Purchase amount of ${purchaseAmount} successfully applied to Member {memberId}.");
			}

			//T- Make a return
			else if (userChoiceString == "T") 
			{
				Console.WriteLine("Make a return:");

				//find existing member id
				string returnQuestion = "Enter existing Membership ID to apply a refund to:";
				int memberId = askForUniqueMemberId(returnQuestion, memberships, false);

				//enter refund amount; must be greater than $0.00
				int low = 0;
				string moneyQuestion = $"Enter refund amount: (> ${low}.00)";
				double refundAmount = askForValidMoneyAmount(moneyQuestion, low);

				foreach(Membership aMember in memberships) 
				{
					if (aMember.MembershipId == memberId) 
					{
						aMember.MonthlyPurchaseTotal = aMember.MonthlyPurchaseTotal - refundAmount;
					}
				}

				Console.WriteLine($"Refund amount of ${refundAmount} successfully applied to Member {memberId}.");

			}

			//A- Apply cashback rewards
			else if (userChoiceString == "A") 
			{
				Console.WriteLine("Apply cashback rewards:");

				//find existing member id
				string cashBackQuestion = "Enter existing Membership ID to apply cashback rewards to:";
				int memberId = askForUniqueMemberId(cashBackQuestion, memberships, false);

				//look up member based on id, then apply cashback logic based on which member type
				foreach(Membership aMembership in memberships) 
				{
					if (aMembership.MembershipId == memberId) 
					{
						aMembership.MonthlyPurchaseTotal = aMembership.ApplyCashbackReward();
					}
				}
			}

			//Q - Quit program
			else 
			{
				Console.WriteLine("Goodbye");
			}

		} while (!(userChoiceString == "Q"));
    }
  }
}