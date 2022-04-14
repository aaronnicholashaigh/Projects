using System;

namespace TempConversion
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("What is the temperature (number only) that you would like to convert?");
            double userTemp = Convert.ToInt32(Console.ReadLine());

          Console.WriteLine("Would you like to convert to Fahrenheit or Celsius?");
           string userScale = Console.ReadLine();

         while (userScale != "Fahrenheit" && userScale != "Celsius")
           {
             Console.WriteLine("Temperature must be in Fahrenheit or Celsius. Please re-enter your scale.");
             userScale = Console.ReadLine();
           }

           double newCTemp = (userTemp-32)/1.8; 
           double newFTemp = (userTemp*1.8)+32;
         
            if (userScale == "Fahrenheit") 
           {
            Console.WriteLine("Your converted temperature is " + newFTemp + " degrees Fahrenheit");
           }

            else
           {
             Console.WriteLine("Your converted temperature is " + newCTemp + " degrees Celsius");
           }
        }
    }
}