using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {

        //Declare my variables
        bool userChoice;
        string userChoiceString;
        Hourly [] hourlyArray = new Hourly [25];
        for (int index = 0; index < hourlyArray.Length; index++)
        {
          hourlyArray[index] = new Hourly();
        }

        Salary [] salaryArray = new Salary [25];
        for (int index = 0; index < salaryArray.Length; index++)
        {
          salaryArray[index] = new Salary();
        }


        //Repeat main loop while the users choice does not equal Q or q
        do 
        {

          //TODO: Get a valid input
          do
          {

            //initialize my bool variable
            userChoice = false;

            //TODO: Provide the user a menu of options:
            Console.WriteLine("Please select an option:");
            Console.WriteLine("L: Load the employee data file:");
            Console.WriteLine("S: Save the employee data file:");
            Console.WriteLine("C: Add an employee to the file:");
            Console.WriteLine("R: Print employee information:");
            /* Console.WriteLine("U: Update employee information in the array.");
            Console.WriteLine("D: Delete an employee from the array."); */
            Console.WriteLine("Q: Quit the program.");

            //TODO: Get a user option (valid means it's on the menu)

            userChoiceString = Console.ReadLine();

            userChoice = (userChoiceString == "L" || userChoiceString == "l" ||
                          userChoiceString == "S" || userChoiceString == "s" ||
                          userChoiceString == "C" || userChoiceString == "c" ||
                          userChoiceString == "R" || userChoiceString == "r" ||
                          userChoiceString == "U" || userChoiceString == "u" ||
                          userChoiceString == "D" || userChoiceString == "d" ||
                          userChoiceString == "Q" || userChoiceString == "q");
            if (!userChoice)
            {
              Console.WriteLine("Please enter a valid option.");
            }

          }while (!userChoice);


          //ToDo: If the option is L or l then load the employee text file (employee.txt) into the array of strings (employeeArray)
          if (userChoiceString == "L" || userChoiceString == "l")
          {
            Console.WriteLine("In the L/l area");
            
            //Create a streamreader so that info may be read from the text file
            /* using (StreamReader sr = File.OpenText("employee.txt"))
            {
              for (int index = 0; index < salaryArray.Length; index++)
              {
                //if (!(hourlyArray[index] == null))
                {
                  salaryArray[index] = new Salary (sr.ReadLine());
                }
              }
            } */
          


          }

          //ToDo: Else if the option is S or s then store the employeeArray into the employee.txt file.
          else if (userChoiceString == "S" || userChoiceString == "s")
          {
            Console.WriteLine("In the S/s area");
          }

          //ToDo: Else if the option is C or c then add an employee to the array (if there's room)
          else if (userChoiceString == "C" || userChoiceString == "c")
          {
            Console.WriteLine("in the C/c area.");
            string addFirstName = "";
            string addLastName = "";
            char addEmployeeStatus = '0';
            float addHourlyPay = 0.00f;
            int addSalaryPay = 0;

            //Prompt the user for the employees First Name
            do 
            {
              Console.WriteLine("Please enter the employees First Name.");
              addFirstName = Console.ReadLine();
              if (addFirstName == "")
              {
                Console.WriteLine("Invalid entry, please enter the employees first name.");
              }  
            } while (addFirstName == "");


            //Prompt the user to enter an employee last name 
            do
            {
              Console.WriteLine("Please enter the employee's Last Name.");
              addLastName = Console.ReadLine();
              if (addLastName == "")
              {
                Console.WriteLine("Invalid entry, please enter the employee's last name.");
              } 
            } while (addLastName == "");


            //Prompt the user for the employees employment status
            do
            {
              Console.WriteLine("Please enter H for hourly or S for Salary.");
              addEmployeeStatus = Convert.ToChar(Console.ReadLine());
              if (addEmployeeStatus != 'H' && addEmployeeStatus != 'S')
              {
                Console.WriteLine("Invalid entry, please enter the employee's employment status.");
              }
            } while (addEmployeeStatus != 'H' && addEmployeeStatus != 'S');

            
            //Prompt the user for the employee's wage
            if (addEmployeeStatus == 'H' || addEmployeeStatus == 'h')
            {
              do
              {

                Console.WriteLine("Please enter the employees hourly wage:");
                addHourlyPay = float.Parse(Console.ReadLine());
                if (addHourlyPay < -1.00 || addHourlyPay > 1000.00)
                {
                  Console.WriteLine("Invalid entry, please enter the employee's hourly pay.");
                }

              }while (addHourlyPay < -1.00 || addHourlyPay > 1000.00);
  
            }

            else 
            {
              do
              {
                Console.WriteLine("Please enter the employees yearly salary:");
                addSalaryPay = Convert.ToInt32(Console.ReadLine());
                if (addSalaryPay < 1.00 || addSalaryPay > 10000000.00)
                {
                  Console.WriteLine("Invalid entry, please enter the employee's salary.");
                }
              } while (addSalaryPay < -1.00 || addSalaryPay > 10000000.00);
            }
            
            
            if (addEmployeeStatus == 'H')
            {
              bool employeeSpaceFound = false;
              for (int index = 0; index < hourlyArray.Length; index++)
              {
                if ((hourlyArray[index] == null) && employeeSpaceFound == false)
                {
                  Console.WriteLine("The employee has been added.");
                  hourlyArray[index] = new Hourly (addHourlyPay, addFirstName, addLastName, addEmployeeStatus);
                  //employeeArray[index] = new Salary (addSalaryPay, addFirstName, addLastName, addEmployeeStatus);
                  employeeSpaceFound = true;

                }
              }
              if (employeeSpaceFound == false)
              {
                Console.WriteLine("Employee file is full.");
              } 
            }
            else 
            {
              bool employeeSpaceFound = false;
              for (int index = 0; index < salaryArray.Length; index++)
              {
                if ((salaryArray[index] == null) && employeeSpaceFound == false)
                {
                  Console.WriteLine("The employee has been added.");
                  salaryArray[index] = new Salary (addSalaryPay, addFirstName, addLastName, addEmployeeStatus);
                  employeeSpaceFound = true;

                }
              }
              if (employeeSpaceFound == false)
              {
                Console.WriteLine("Employee file is full.");
              } 
            }
          }

            // If the option is R or r, print of the list of employees with their calculated bonuses
            else if (userChoiceString=="R" || userChoiceString=="r")
            {
              Console.WriteLine("In the R/r area!!!");
              for (int index = 0; index < salaryArray.Length; index++)
              {
                if (!(hourlyArray[index]==null))
                {
                    Console.WriteLine(hourlyArray[index]);
                } 
              }
              for (int index = 0; index < salaryArray.Length; index++)
              {
                if (!(salaryArray[index]==null))
                {
                    Console.WriteLine(salaryArray[index]);
                } 
              }
            }
        
            /* TODO: Else if the option is a U or u
            else if (userChoiceString=="U" || userChoiceString=="u")
            {
                Console.WriteLine("In the U/u area");
            } */
        
            /* TODO: Else if the option is a D or d
            else if (userChoiceString=="D" || userChoiceString=="d")
            {
                Console.WriteLine("In the D/d area");
            } */
        
            //Else if the option is a Q or q then quit the program
            else 
            {
                Console.WriteLine("Goodbye User!");
            }
        } while (!(userChoiceString == "Q") && !(userChoiceString == "q"));
      } 
  } 
} 