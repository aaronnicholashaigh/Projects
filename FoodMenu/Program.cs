using System;

namespace FoodMenu
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] mainMeals = {"Cheesy Chicken Casserole", "Stir-Fry", "Spaghetti", "Mac and Cheese", "Alfredo", "Soup"};
           string[] sideDishes = {"Garlic Bread", "Pan Potatoes", "Twice-Baked Potatoes", "Potatoes Romanoff"};
           string[] fruitsAndVeggies = {"Oranges", "Peaches", "Melon", "Pears", "Broccoli", "Carrots", "Spinach", "Pickles"};

           //Console.WriteLine(mainMeals[1]);                              //Print specified option from the array {string [] mainMeals}
           //Console.WriteLine(sideDishes[2]);                             //Print specified option from the array {string [] sideDishes}
           //Console.WriteLine(fruitsAndVeggies[5]);                       //Print specified option from  the array {string [] fruitsAndVeggies}

           ///Picking a random selection of the array
           Random rand = new Random();                                                   //create a Random object
           int index =rand.Next(mainMeals.Length);                                       //generate a random index less than the size of the array
           Console.WriteLine($"Randomly selected main meal is {mainMeals[index]}");       //print the result

            ///Change an Array Element and print it///
           mainMeals[2] = "Changed meal name";                             //Change an Array Element
           Console.WriteLine(mainMeals[2]);   

           ///Print Array Length///
           Console.WriteLine($"Side Dishes array contains {sideDishes.Length} items.");
           Console.WriteLine("Fruits and Veggies contains " + fruitsAndVeggies.Length + " items.");
        }
    }
}