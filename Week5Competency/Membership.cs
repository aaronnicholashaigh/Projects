using System;

namespace CustomerMemberships
{
	abstract class Membership
  {
		public int MembershipId
		{get; set;}

		public string Email
		{get; set;}

		public string MembershipType
		{get; set;}

		public double AnnualCost
		{get; set;}

		public double MonthlyPurchaseTotal
		{get; set;}

		//default constructor
		public Membership() 
        {
			MembershipId = -1;
			Email = "";
			MembershipType = "";
			AnnualCost = -1D;
			MonthlyPurchaseTotal = -1D;
		}

		//constructor passing parameters
		public Membership(int newId, string newEmail, string newType, double newCost, double newTotal) 
        {
			MembershipId = newId;
			Email = newEmail;
			MembershipType = newType;
			AnnualCost = newCost;
			MonthlyPurchaseTotal = newTotal;
		}

		//general purchase method
		public double Purchase(double purchaseAmount) 
        {
			return MonthlyPurchaseTotal += purchaseAmount;
		}

		//general return method
		public double Return(double returnAmount) 
        {
			return MonthlyPurchaseTotal -= returnAmount;
		}

		//abstract cashback method
		public abstract double ApplyCashbackReward();

		public override string ToString() 
        {
			return $"\nMembership Id: {MembershipId}\nEmail Address: {Email}\nMembership Type: {MembershipType}\nAnnual Cost: ${AnnualCost}\nMonthly Purchase Total: ${MonthlyPurchaseTotal}";
		}
  }
}