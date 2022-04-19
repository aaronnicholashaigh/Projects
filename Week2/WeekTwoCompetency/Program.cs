using System;
using System.IO;

namespace CreateFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Variables
            string userChoiceString;
            bool userChoice;

            string[] restaurantNameArray = new string[25];
            string[] restaurantRatingArray = new string[25];

            do
            {

            //TODO: get a valid input
                do
                {
                    //Initialize variables
                    userChoice = false;

                    //TODO: Provide the user a menu of options
                    Console.WriteLine("Please enter an option:");
                    Console.WriteLine("Enter 'O' to load the data file into an array:");
                    Console.WriteLine("Enter 'S' to save your list:");
                    Console.WriteLine("Enter 'C' to add a restaurant and rating:");
                    Console.WriteLine("Enter 'R' to print a list of all restaurants and their ratings:");
                    Console.WriteLine("Enter 'Q' to quit the program:");
                    Console.WriteLine("");

                    //TODO: Get a user option (valid means it is on the menu)
                    userChoiceString = Console.ReadLine();

                    userChoice =        (userChoiceString == "O" || userChoiceString == "o" ||
                                        userChoiceString == "S" || userChoiceString == "s" ||
                                        userChoiceString == "C" || userChoiceString == "c" ||
                                        userChoiceString == "R" || userChoiceString == "r" ||
                                        userChoiceString == "Q" || userChoiceString == "q");

                    if (!userChoice)
                    {
                     Console.WriteLine("Please enter a valid option:");
                     }


                } while (!userChoice);


                //"Enter 'O' to load the data file into an array:"
                if (userChoiceString == "O" || userChoiceString == "o")
                {
                    int index = 0;   //index for the array
                    using (StreamReader sr = File.OpenText("names.txt"))
                    {
                        string s = "";
                        Console.WriteLine(" Here is the content of the file");
                        while ((s = sr.ReadLine()) !=null)
                        {
                            Console.WriteLine(s);
                            restaurantNameArray[index] = s;
                            index = index + 1;
                        }
                    }
                }

                //"Enter 'S' to store the array into a text file:"
                else if (userChoiceString == "S" || userChoiceString == "s")
                {

                    Console.WriteLine("In the S/s area!");
                    int index = 0;

                    //delete the file if it exists
                    if (File.Exists("names.txt"))
                    {
                        File.Delete("names.txt");
                    }

                    //create the file
                    using (StreamWriter fileStr = File.CreateText("names.txt"))
                    {
                        for (index = 0; index < 25; index++)
                        {
                            fileStr.WriteLine(restaurantNameArray[index]);
                        }
                    }
                    Console.WriteLine("names.txt" + " has been saved.");
                    Console.WriteLine("");
                }

                //"Enter 'C' to to add a name to the array:"
                else if (userChoiceString == "C" || userChoiceString == "c")
                {
                    Console.WriteLine("In the S/s area!");
                    int index = 0;
                    Console.WriteLine("What name do you want to add?");
                    string newName = Console.ReadLine();
                    bool found = false;
                    
                    for (index = 0; index < 25; index++)
                    {
                        if ((restaurantNameArray[index] == "") && found == false)
                        {
                            restaurantNameArray[index] = newName;
                            found = true;
                            Console.WriteLine(restaurantNameArray[index]);
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine("There is no space to add");
                    }
                }

                //"Enter 'R' to read a name from the array:"
                else if (userChoiceString == "R" || userChoiceString == "r")
                {
                    Console.WriteLine("In the R/r area!");
                    for (int index = 0; index < 25; index++)
                    {
                        Console.WriteLine(restaurantNameArray[index]);
                    }
                }

                //"Enter 'Q' to quit the program:"
                else 
                {
                    Console.WriteLine("Goodbye!");
                }
            } while (!(userChoiceString == "Q") && !(userChoiceString == "q"));

        }
    }
}