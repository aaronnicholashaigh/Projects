using System;

namespace QuizMath
{
    class Program
    {
            static int MyMin (int x, int y)  
            {
                if (x < y)
                {
                   return(x); 
                }
                
                else
                {
                    return(y);
                }

            }

           static int MyMax (int x, int y)
            {
                if (x > y)
                {
                   return(x); 
                }
                
                else
                {
                    return(y);
                }

            }

            static int GetValidInt(int lowRangeValue, int highRangeValue)
            {
                
                Console.WriteLine("Enter a value between " + lowRangeValue + " and" + highRangeValue);
                int validValue = Convert.ToInt32(Console.ReadLine());
                

                while (validValue < lowRangeValue || validValue > highRangeValue)
                {
                    Console.WriteLine("The value must be between " + lowRangeValue + " and" + highRangeValue);
                    validValue = Convert.ToInt32(Console.ReadLine());
                }

                return validValue;
            }    

            

        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount of tests:");
            int amountOfQuizzes = GetValidInt(1,1000);

            int minQuiz = 101;
            int maxQuiz = 0;
            int averageQuiz = 0;
            
            for (int newQuiz = 0; newQuiz < amountOfQuizzes; newQuiz++)
            {
                Console.WriteLine("Please enter quiz score " + (newQuiz+1));
                int quizScore = GetValidInt(0,100);
               

                minQuiz = MyMin(quizScore, minQuiz);

                maxQuiz = MyMax(quizScore, maxQuiz);

                averageQuiz = averageQuiz+quizScore;
            }   
            
            Console.WriteLine("The minimum score is " + minQuiz);
            Console.WriteLine("The maximum score is " + maxQuiz);
            Console.WriteLine("The average score is " + (averageQuiz/amountOfQuizzes));
        }
    }
}