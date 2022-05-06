using System;

namespace CustomerMemberships
{
	class Executive: Membership, ISpecialOffer
  {
		public double CashBackPercent
		{get; set;}

		//default constructor
		public Executive(): base() {}

		//constructor passing parameters
		public Executive(int newId, string newEmail, string newType, double newCost, double newTotal, double newPercent): base(newId, newEmail, newType, newCost, newTotal) 
        {
			CashBackPercent = newPercent;
		}
		
		//two tiers. Below $1k = 3.5%, about = 7%
		public override double ApplyCashbackReward() 
        {
			//if monthlypuchasetotal == 0 (ex: if cashback already applied)
			if (MonthlyPurchaseTotal == 0) 
            {
				Console.WriteLine($"Member {MembershipId}'s Monthly Purchase Total is $0.00. Cannot apply Cash Back Bonus. Buy more stuff!");
			}

			//if monthly purchase total greater than $1000.00
			else if (MonthlyPurchaseTotal < 1000.00) 
            {
				double cashBack = MonthlyPurchaseTotal * (CashBackPercent / 100);
				string cashBackTwoDecimal = cashBack.ToString("#.##");
				Console.WriteLine($"\nSuccess! {CashBackPercent}% of ${MonthlyPurchaseTotal} gives you a Cash-Back Reward of ${cashBackTwoDecimal} applied to Membership {MembershipId}.");
				
				//set monthly purchase total to 0.00
				MonthlyPurchaseTotal = 0D;
			} 

			//if monthly purchase total > 0.00 and < 1000.00
			else 
            {
				double doublePercent = CashBackPercent * 2;
				double cashBack = MonthlyPurchaseTotal * (doublePercent / 100);
				string cashBackTwoDecimal = cashBack.ToString("#.##");
				Console.WriteLine($"\nSuccess! {doublePercent}% of ${MonthlyPurchaseTotal} gives you a Cash-Back Reward of ${cashBackTwoDecimal} applied to Membership {MembershipId}.");
				
				//set monthly purchase total to 0.00
				MonthlyPurchaseTotal = 0D;
			}
			return MonthlyPurchaseTotal;
		}

		//interface special offer
		public double SpecialOffer() 
        {
			return AnnualCost * 0.5;
		}

		public override string ToString() 
        {
			return base.ToString() + $"\nSpecial Offer! Your {MembershipType} Membership costs ${SpecialOffer()}";
		}
  }
}