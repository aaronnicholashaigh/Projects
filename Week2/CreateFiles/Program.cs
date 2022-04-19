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

            string[] nameArray = new string[10];
            Console.WriteLine"hi";
          

            do
            {

            //TODO: get a valid input
                do
                {
                    //Initialize variables
                    userChoice = false;

                    //TODO: Provide the user a menu of options
                    Console.WriteLine("Please enter an option:");
                    Console.WriteLine("Enter 'L' to load the data file into an array:");
                    Console.WriteLine("Enter 'S' to store the array into a text file:");
                    Console.WriteLine("Enter 'C' to to add a name to the array:");
                    Console.WriteLine("Enter 'R' to read a name from the array:");
                    Console.WriteLine("Enter 'U' to update a name in the array:");
                    Console.WriteLine("Enter 'D' to delete a name from the array:");
                    Console.WriteLine("Enter 'Q' to quit the program:");
                    Console.WriteLine("");

                    //TODO: Get a user option (valid means it is on the menu)
                    userChoiceString = Console.ReadLine();

                    userChoice =        (userChoiceString == "L" || userChoiceString == "l" ||
                                        userChoiceString == "S" || userChoiceString == "s" ||
                                        userChoiceString == "C" || userChoiceString == "c" ||
                                        userChoiceString == "R" || userChoiceString == "r" ||
                                        userChoiceString == "U" || userChoiceString == "u" ||
                                        userChoiceString == "D" || userChoiceString == "d" ||
                                        userChoiceString == "Q" || userChoiceString == "q");

                    if (!userChoice)
                    {
                     Console.WriteLine("Please enter a valid option:");
                     }


                } while (!userChoice);


                //"Enter 'L' to load the data file into an array:"
                if (userChoiceString == "L" || userChoiceString == "l")
                {
                    int index = 0;   //index for the array
                    using (StreamReader sr = File.OpenText("names.txt"))
                    {
                        string s = "";
                        Console.WriteLine(" Here is the content of the file");
                        while ((s = sr.ReadLine()) !=null)
                        {
                            Console.WriteLine(s);
                            nameArray[index] = s;
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
                        for (index = 0; index < 10; index++)
                        {
                            fileStr.WriteLine(nameArray[index]);
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
                    
                    for (index = 0; index < 10; index++)
                    {
                        if ((nameArray[index] == "") && found == false)
                        {
                            nameArray[index] = newName;
                            found = true;
                            Console.WriteLine(nameArray[index]);
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
                    for (int index = 0; index < 10; index++)
                    {
                        Console.WriteLine(nameArray[index]);
                    }
                }

                //"Enter 'U' to update a name in the array:"
                else if (userChoiceString == "U" || userChoiceString == "u")
                {
                    Console.WriteLine("In the U/u area!");
                    Console.WriteLine("What name do you want to update?");
                    string whichName = Console.ReadLine();

                    bool contains = false;
                    for (int i = 0; i < nameArray.Length; i++)
                    {
                        if (whichName == nameArray[i]);
                        {
                            contains = true;
                        }
                    }
                }

                //"Enter 'D' to delete a name from the array:"
                else if (userChoiceString == "D" || userChoiceString == "d")
                {
                    Console.WriteLine("In the D/d area!");
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