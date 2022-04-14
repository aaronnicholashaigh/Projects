using System;

namespace ArrayDataStructure
{
    class Program
    {

        public static void CreateGrid ()
        {
            int width = 5;
            int height = 5;
            int[,] numberGrid = new int[width,height];
            //grid [4,4] = 3;

            for (int x = 0; x < width; x++)
            {
                
                for (int y = 0; y < height; y++)
                {
                    numberGrid [x,y] = x+y;
                    Console.Write (numberGrid [x, y] + " ");
                }
                Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {
           int[] scores = new int[10];
           int baseQuiz = 0;
           scores[baseQuiz] = 0;

            for (baseQuiz = 0; baseQuiz < 10; baseQuiz++ )
            {
                
                Console.WriteLine("Please enter a score:");                        // receive the amount of scores from the user
                scores[baseQuiz] = Convert.ToInt32(Console.ReadLine());            //store the amount of scores as int scoreQuantity

            }

            //Obtain maximim score
            int max = scores[0];
            for (int x = 1; x <10; x++)
            {
                int maxValue = scores[x];

                if (maxValue > max)
                {
                    max = maxValue;
                }
            }

            //Obtain minimum score
            int min = scores[0];
            for (int x = 1; x <10; x++)
            {
                int minValue = scores[x];

                if (minValue < min)
                {
                    min = minValue;
                }
            }

            
            foreach (int newNumber in scores)
            {
                
            }


            Console.WriteLine("The Min is: " + min);
            Console.WriteLine("The Max is: " + max);
            Console.WriteLine("The Average score is: " + scores.Average());

            //Console.WriteLine("The Average score is: " + ave);
        }
    }
}
