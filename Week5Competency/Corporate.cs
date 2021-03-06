using System;

namespace CustomerMemberships
{
	class Corporate: Membership
  {
		public double CashBackPercent
		{get; set;}

		//default constructor
		public Corporate(): base() {}

		//constructor passing parameters
		public Corporate(int newId, string newEmail, string newType, double newCost, double newTotal, double newPercent): base(newId, newEmail, newType, newCost, newTotal) 
        {
			CashBackPercent = newPercent;
		}
	
		//10% cashback, then zero out monthly total
		public override double ApplyCashbackReward() 
        {
			if (MonthlyPurchaseTotal > 0) 
            {
				double cashBack = MonthlyPurchaseTotal * (CashBackPercent / 100);
				string cashBackTwoDecimal = cashBack.ToString("#.##");
				Console.WriteLine($"\nSuccess! {CashBackPercent}% of ${MonthlyPurchaseTotal} gives you a Cash-Back Reward of ${cashBackTwoDecimal} applied to Membership {MembershipId}.");

				MonthlyPurchaseTotal = 0D;
			}

			//if monthlypuchasetotal == 0 (ex: if cashback already applied)
			else 
            {
				Console.WriteLine($"Member {MembershipId}'s Monthly Purchase Total is $0.00. Cannot apply Cash Back Bonus. Buy more stuff!");
			}

			return MonthlyPurchaseTotal;
		}

		public override string ToString() 
        {
			return base.ToString();
		}
  }
}