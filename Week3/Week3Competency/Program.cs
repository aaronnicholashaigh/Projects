using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
        bool userChoice;
        string userChoiceString;

        //create my array and instantiate each object in the array
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
            Console.WriteLine("Employee Bonus File:");
            Console.WriteLine("L: Load the employee data from the file:");
            Console.WriteLine("S: Save the employee data into the file:");
            Console.WriteLine("C: Add an employee to the file:");
            Console.WriteLine("R: Print the employee bonus information:");
            Console.WriteLine("U: Update employee information in the array.");
            Console.WriteLine("D: Delete an employee from the array.");
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
          
            using (StreamReader sr = File.OpenText("employee.txt"))
            {
                int salaryIndex = 0;
                int hourlyIndex = 0;

                
                string firstName;
                string lastName;
                char employeeType;
                float hourlyPay = 0.0f;
                int salaryPay;
				
                while ((firstName = sr.ReadLine()) != null)
                {
                  Console.WriteLine(firstName);
                    lastName = sr.ReadLine();
                    Console.WriteLine(lastName);
                    employeeType = Convert.ToChar(sr.ReadLine());
                    Console.WriteLine(employeeType);
                    
                    if (employeeType == 'H' || employeeType == 'h')
                    {
                      hourlyPay = Convert.ToSingle(sr.ReadLine());
                      hourlyArray[hourlyIndex].firstName = firstName;
                      hourlyArray[hourlyIndex].setEmployeeLastName(lastName);
                      hourlyArray[hourlyIndex].employeeType = employeeType;
                      hourlyArray[hourlyIndex].HourlyPay = hourlyPay;

                      hourlyIndex = hourlyIndex + 1;
                    }
                    else
                    {
                      salaryPay = Convert.ToInt32(sr.ReadLine());
                      
                      salaryArray[salaryIndex].firstName = firstName;
                      salaryArray[salaryIndex].setEmployeeLastName(lastName);
                      salaryArray[salaryIndex].employeeType = employeeType;
                      salaryArray[salaryIndex].SalaryPay = salaryPay;

                      salaryIndex = salaryIndex + 1;
                    }
                }
                    Console.WriteLine(" Here is the content of the file employee.txt : ");
                    Console.WriteLine("");
                    for (int index = 0; index <25; index ++)
                    {
                    Console.WriteLine(hourlyArray[index]);
                    Console.WriteLine(salaryArray[index]);
                    
                    }
                    Console.WriteLine("");
            }
          }

          //ToDo: Else if the option is S or s then store the employeeArray into the employee.txt file.
          else if (userChoiceString == "S" || userChoiceString == "s")
          {
            Console.WriteLine("In the S/s area");
            using (StreamWriter sw = File.CreateText("employee.txt"))
            {
              for (int index = 0; index < hourlyArray.Length; index++)
              {
                if (!(((hourlyArray[index]).getEmployeeLastName())==null))
                {
                  sw.WriteLine(hourlyArray[index].firstName);
                  sw.WriteLine(hourlyArray[index].getEmployeeLastName());
                  sw.WriteLine(hourlyArray[index].employeeType);
                  sw.WriteLine(hourlyArray[index].HourlyPay);
                }

                if (!(((salaryArray[index]).getEmployeeLastName())==null))
                {
                  sw.WriteLine(salaryArray[index].firstName);
                  sw.WriteLine(salaryArray[index].getEmployeeLastName());
                  sw.WriteLine(salaryArray[index].employeeType);
                  sw.WriteLine(salaryArray[index].SalaryPay);
                }
              }
            }
          }

          //ToDo: Else if the option is C or c then add an employee to the array (if there's room)
          else if (userChoiceString == "C" || userChoiceString == "c")
          {
            Console.WriteLine("in the C/c area.");
            string addFirstName = "";
            string addLastName = "";
            char addEmployeeStatus = '\0';
            float addHourlyPay = 0.00F;
            int addSalaryPay = 0;

            do 
            {
              Console.WriteLine("Please enter the employees First Name.");
              addFirstName = Console.ReadLine();
              if (addFirstName == "")
              {
                Console.WriteLine("Entry was not valid, please enter the employees first name.");
              }  
            } while (addFirstName == "");

            do
            {
              Console.WriteLine("Please enter the employee's Last Name.");
              addLastName = Console.ReadLine();
              if (addLastName == "")
              {
                Console.WriteLine("Entry was not valid, please enter the employee's last name.");
              } 
            } while (addLastName == "");

            do
            {
              Console.WriteLine("Please enter in an H if the employee is Hourly and an S if the employee is salary.");
              addEmployeeStatus = Convert.ToChar(Console.ReadLine());
              if (addEmployeeStatus != 'H' && addEmployeeStatus != 'S')
              {
                Console.WriteLine("Entry was not valid, please enter the employee's employment status.");
              }
            } while (addEmployeeStatus != 'H' && addEmployeeStatus != 'S');

            if (addEmployeeStatus == 'H' || addEmployeeStatus == 'h')
            {
              do
              {
                Console.WriteLine("Please enter the hourly pay for the employee.");
                addHourlyPay = float.Parse(Console.ReadLine());
                if (addHourlyPay < -1F || addHourlyPay > 1000F)
                {
                  Console.WriteLine("Entry was not valid, please enter the employee's hourly pay.");
                }

              }while (addHourlyPay < -1F || addHourlyPay > 1000F);
  
            }

            else 
            {
              do
              {
                Console.WriteLine("Please enter the salary pay for the employee.");
                addSalaryPay = Convert.ToInt32(Console.ReadLine());
                if (addSalaryPay < -1 || addSalaryPay > 10000000)
                {
                  Console.WriteLine("Entry was not valid, please enter the employee's hourly pay.");
                }
              } while (addSalaryPay < -1 || addSalaryPay > 10000000);
            }
            
            
            if (addEmployeeStatus == 'H')
            {
              bool employeeSpaceFound = false;
              for (int index = 0; index < hourlyArray.Length; index++)
              {
                if ((hourlyArray[index].getEmployeeLastName() == null) && employeeSpaceFound == false)
                {
                  Console.WriteLine("The employee has been added.");
                  hourlyArray[index].firstName = addFirstName;
                  hourlyArray[index].setEmployeeLastName(addLastName);
                  hourlyArray[index].employeeType = addEmployeeStatus;
                  hourlyArray[index].HourlyPay = addHourlyPay;
                  employeeSpaceFound = true;

                }
              }
              if (employeeSpaceFound == false)
              {
                Console.WriteLine("Employee array is full. Employee information has not been saved.");
              } 
            }
            else 
            {
              bool employeeSpaceFound = false;
              for (int index = 0; index < salaryArray.Length; index++)
              {
                if ((salaryArray[index].getEmployeeLastName() == null) && employeeSpaceFound == false)
                {
                  Console.WriteLine("There is space. The employee has not been added.");
                  //salaryArray[index] = new Salary (addSalaryPay, addFirstName, addLastName, addEmployeeStatus);
                  salaryArray[index].firstName = addFirstName;
                  salaryArray[index].setEmployeeLastName(addLastName);
                  salaryArray[index].employeeType = addEmployeeStatus;
                  salaryArray[index].SalaryPay = addSalaryPay;
                  employeeSpaceFound = true;

                }
              }
              if (employeeSpaceFound == false)
              {
                Console.WriteLine("Employee array is full. Employee information has not been saved.");
              } 
            }
          }

          
            //ToDo: Else if the option is an R or r then print a list of all of the employees including their calculated bonus.
            else if (userChoiceString=="R" || userChoiceString=="r")
            {
                Console.WriteLine("");

                for (int index = 0; index < salaryArray.Length; index++)
                {
                  if (!(((salaryArray[index]).getEmployeeLastName())==null))
                    Console.WriteLine(salaryArray[index]);
                }

                for (int index = 0; index < hourlyArray.Length; index++)
                {
                  if (!(((hourlyArray[index]).getEmployeeLastName())==null))
                    Console.WriteLine(hourlyArray[index]);
                }
                Console.WriteLine("");
            }
          
          /* ToDo: Else if the option is a U or u then update information for an employee in the array (if it's there)
            else if (userChoiceString=="U" || userChoiceString=="u")
            {
                Console.WriteLine("In the U/u area");
            }

          
          TODO: Else if the option is a D or d then delete the name in the array (if it's there)
            else if (userChoiceString=="D" || userChoiceString=="d")
            {
                Console.WriteLine("In the D/d area");
            } */
        
          //  TODO: Else if the option is a Q or q then quit the program
            else 
            {
                Console.WriteLine("Goodbye");
            }
          } while (!(userChoiceString == "Q") && !(userChoiceString == "q"));
        }
  }
}