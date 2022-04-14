using System;

namespace FeetToInches
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("What is the temperature (number only) that you would like to convert?");
            double userTemp = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Would you like to convert to Fahrenheit or Celsius?");
           string userScale = Console.ReadLine();

           double newCTemp = ((userTemp*1.8)+32);
           double newFTemp = ((userTemp-32)*(5/9));
         
            if (userScale == "Fahrenheit") 
           {
            Console.WriteLine("Your converted temperature is " + newCTemp + " degrees Celsius");
           }

           else 
           {
             Console.WriteLine("Your converted temperature is " + newFTemp + " degrees Fahrenheit");
           }
        }
    }
}
