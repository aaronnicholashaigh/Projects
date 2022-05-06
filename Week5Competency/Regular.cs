using System;

namespace CustomerMemberships
{
	class Regular: Membership, ISpecialOffer
  {
		public double CashBackPercent
		{ get; set; }

		//default constructor
		public Regular(): base() {}

		//constructor passing parameters
		public Regular(int newId, string newEmail, string newType, double newCost, double newTotal, double newPercent): base(newId, newEmail, newType, newCost, newTotal) {
			CashBackPercent = newPercent;
		}
		
		//5% cashback, then zero out
		public override double ApplyCashbackReward() {
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

		//interface special offer (25%)
		public double SpecialOffer() 
        {
			return AnnualCost * 0.25;
		}

		public override string ToString() 
        {
			return base.ToString() + $"\nSpecial Offer! Your {MembershipType} Membership costs only ${SpecialOffer()}";
		}
  }
}