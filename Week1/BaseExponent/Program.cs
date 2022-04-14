using System;

namespace QuizMath
{
    class Program
    {
        static int GetPowerMethod (int x, int y)  
            {
                int currentTotal = 1;
                for (int value = 0; value < y; value++)               
                    {
                        currentTotal = currentTotal * x;
                                          
                    }
                return currentTotal;    

            }        

        static int GetValidInt(int lowRangeValue, int highRangeValue)
            {
                
                Console.WriteLine("Enter a value between " + lowRangeValue + " and " + highRangeValue);
                int validValue = Convert.ToInt32(Console.ReadLine());
                

                while (validValue < lowRangeValue || validValue > highRangeValue)
                {
                    Console.WriteLine("The value must be between " + lowRangeValue + " and " + highRangeValue);
                    validValue = Convert.ToInt32(Console.ReadLine());
                }

                return validValue;
            } 


        static void Main(string[] args)
        {
            int begExponent = 0;
            int endExponent = 0;
            string goAgain;
            

            do
            {
                Console.WriteLine("What is the base number?");                      
                int baseValue = GetValidInt(1,100);              
            
                Console.WriteLine("What is the exponent?");                          
                int exponentValue = GetValidInt(2,10);     

                Console.WriteLine(baseValue + " ^ " + exponentValue + " = " + GetPowerMethod(baseValue,exponentValue));
                
                Console.WriteLine("Would you like to try again? Yes or No?");
                goAgain = Console.ReadLine();
            }
            while (goAgain == "Yes");
               
        }
    }
}             