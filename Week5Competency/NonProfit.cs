using System;

namespace CustomerMemberships
{
	class NonProfit: Membership
  {
		public double CashBackPercent
		{ get; set; }

		//default constructor
		public NonProfit(): base() {}

		//constructor passing parameters
		public NonProfit(int newId, string newEmail, string newType, double newCost, double newTotal, double newPercent): base(newId, newEmail, newType, newCost, newTotal) 
        {
			CashBackPercent = newPercent;
		}
		
		//non-profit and military cashback.  After use, zero total
		public override double ApplyCashbackReward() 
        {
			//if monthlypuchasetotal == 0 (ex: if cashback already applied)
			if (MonthlyPurchaseTotal == 0) 
            {
				Console.WriteLine($"Member {MembershipId}'s Monthly Purchase Total is $0.00. Cannot apply Cash Back Bonus. Buy more stuff!");
			}

			else if (MonthlyPurchaseTotal > 0) 
            {
				double cashBack = 0D;
				
				//military or education? if so, extra cashback
				Console.WriteLine("Is your nonprofit Military or Education? Y / N");
				string milOrEd = (Console.ReadLine()).ToUpper();

				if (milOrEd == "Y" || milOrEd == "y") 
                {
					cashBack = MonthlyPurchaseTotal * (CashBackPercent / 100);
				} 
                
                else 
                {
					cashBack = MonthlyPurchaseTotal * (CashBackPercent * 2 / 100);
				}
				
				//report to user
				string cashBackTwoDecimal = cashBack.ToString("#.##");
				Console.WriteLine($"\nSuccess! {CashBackPercent}% of ${MonthlyPurchaseTotal} gives you a Cash-Back Reward of ${cashBackTwoDecimal} applied to Membership {MembershipId}.");

				//set monthly purchase total to $0.00
				MonthlyPurchaseTotal = 0D;
			}
			return MonthlyPurchaseTotal;
		}

		public override string ToString() 
        {
			return base.ToString();
		}
  }
}