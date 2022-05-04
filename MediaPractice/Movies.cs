using System;
using System.Collections.Generic;

namespace MediaTypes
{
    class Movies : Media
    {
        public double runTime;
        public string director;

        // Default Constructor
        public Movies(){}

        // Constructor passing values
        public Movies(string aTitle, string aDirector, double aRunTime, int aReleaseDate): base (aTitle, aReleaseDate)
        {
            director = aDirector;
            runTime = aRunTime;
        }

        public override void MediaDescription()
        {
            Console.WriteLine("Video seen on a screen.");
        }
    }
}