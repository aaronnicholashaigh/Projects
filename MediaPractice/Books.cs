using System;
using System.Collections.Generic;

namespace MediaTypes
{
    class Books : Media
    {
        public int pageLength;
        public string author;

        //List<Books> bookList = new List<Books>();
        //bookList.Add(new Books("The Name of the Wind", "Patrick Rothfuss", 662, 2007));

        // Default Constructor
        public Books(){}

        // Constructor passing values
        public Books(string aTitle, string aAuthor, int aPageLength, int aReleaseDate): base(aTitle, aReleaseDate)
        {
            author = aAuthor;
            pageLength = aPageLength;
        }

        public override void MediaDescription()
        {
            Console.WriteLine("Words written on a page.");
        }
    }
    
}