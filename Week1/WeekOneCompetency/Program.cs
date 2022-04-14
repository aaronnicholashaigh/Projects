using System;

namespace QuizMath
{
    class Program
    {

        static int ValidMinimumAmountOfStudents(int lowRangeValue)
            {
                
                int validQuantityOfStudents = Convert.ToInt32(Console.ReadLine());
                

                while (validQuantityOfStudents < lowRangeValue)
                {
                    Console.WriteLine("The number of students must be greater than " + (lowRangeValue-1) + " Please re-enter a number of students greater than zero");
                    validQuantityOfStudents = Convert.ToInt32(Console.ReadLine());
                }

                return validQuantityOfStudents;
            }

        static int GetValidScore(int lowRangeValue, int highRangeValue)
            {
                
                int validValue = Convert.ToInt32(Console.ReadLine());
                

                while (validValue < lowRangeValue || validValue > highRangeValue)
                {
                    Console.WriteLine("The value must be between " + lowRangeValue + " and " + highRangeValue + ". Please re-enter the score:");
                    validValue = Convert.ToInt32(Console.ReadLine());
                }

                return validValue;
            }

        static double ObtainFinalAverage(double x, double y, double z)
        {
            double finalAverage;
            {
                finalAverage = (x*0.5) + (y*0.3) + (z*0.2);  
            }
            return finalAverage;
        }

        static char GetLetterGrade(double finalAverage)
        {
            if (finalAverage >= 90)
            {
                return 'A';
            }
            else if (finalAverage >=80 && finalAverage <90)
            {
                return 'B';
            }
            else if (finalAverage >= 70 && finalAverage < 80)
            {
                return 'C';
            }
            else if (finalAverage >= 60 && finalAverage < 70)
            {
                return 'D';
            }
            else
            {
               return 'F'; 
            }
        }


        static void Main(string[] args)
        {
            double homeworkAverage = 0;
            double quizAverage = 0;
            double examAverage = 0;
            double finalAverage = 0;
            //finalAverage = GetLetterGrade(finalAverage);
            string studentName;

            //Obtain Quantity of Students
            Console.WriteLine("How many students?");
            int quantityOfStudents = ValidMinimumAmountOfStudents(1);
            
            for (int minimumStudents = 0; minimumStudents < quantityOfStudents; minimumStudents++ )
            {
                homeworkAverage = 0;
                quizAverage = 0;
                examAverage = 0;
                finalAverage = 0;


                //Obtain students name
                Console.WriteLine("What is the students name?");
                studentName = Console.ReadLine();

                    //Obtain average of Homework Grades
                    for (double firstHomeworkScore = 0; firstHomeworkScore < 5; firstHomeworkScore++)
                    {
                        Console.WriteLine("Please enter homework score " + (firstHomeworkScore+1) + ":");
                        double homeworkScore = GetValidScore(0,100);
                        homeworkAverage = homeworkAverage+homeworkScore;
                    }

                    //Obtain average of Quiz Grades
                    for (double firstQuizScore = 0; firstQuizScore < 3; firstQuizScore++)
                    {
                        Console.WriteLine("Please enter quiz score " + (firstQuizScore+1) + ":");
                        double quizScore = GetValidScore(0,100);
                        quizAverage = quizAverage+quizScore;
                    }

                    //Obtain average of Exam Grades
                    for (double firstExamScore = 0; firstExamScore < 2; firstExamScore++)
                    {
                        Console.WriteLine("Please enter exam score " + (firstExamScore+1) + ":");
                        double examScore = GetValidScore(0,100);
                        examAverage = examAverage+examScore;
                    }

            
                Console.WriteLine("Student Name: " + studentName);
                Console.WriteLine("Homework Average: " + homeworkAverage/5 );
                Console.WriteLine("Quiz Average: " + quizAverage/3);
                Console.WriteLine("Exam Average: " + examAverage/2);
                finalAverage = ObtainFinalAverage(homeworkAverage/5,quizAverage/3,examAverage/2);
                Console.WriteLine("Final Average: " + finalAverage);
                Console.WriteLine("Final Grade: " + GetLetterGrade(finalAverage));
            }
            
            
        }
    }
}   