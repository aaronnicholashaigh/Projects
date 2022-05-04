using System;
using System.Collections.Generic;

namespace MediaTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //(string aTitle, string aAuthor, int aPageLength, int aReleaseDate): base(aTitle, aReleaseDate)
            Books newBook = new Books("The Name of the Wind", "Patrick Rothfuss", 662, 2007);
            Books newBook1 = new Books();
            newBook1.title = "The Wise Man's Fear";
            newBook.MediaDescription();
            Console.WriteLine(newBook.title);
            Console.WriteLine(newBook1.title);

            List<Books> bookList = new List<Books>();
            bookList.Add(new Books("The Name of the Wind", "Patrick Rothfuss", 662, 2007));
            bookList.Add(new Books("The Wise Man's Fear", "Patrick Rothfuss", 662, 2007));
            bookList.Add(new Books("Fellowship of the Ring", "Tolkien", 423, 1954));
            bookList.Add(new Books("The Two Towers", "Tolkien", 662, 2007));
            bookList.Add(new Books("The Return of the King", "Tolkien", 662, 2007));

            foreach (Books title in bookList)
            {
                Console.WriteLine(title);
            }

           


            
            //(string aTitle, string aDirector, double aRunTime, int aReleaseDate): base (aTitle, aReleaseDate)
            Movies newMovie = new Movies("The Fellowship of the Ring", "Peter Jackson", 178, 2001);
            Movies newMovie1 = new Movies();
            newMovie1.title = "The Two Towers";
            newMovie.MediaDescription();
            Console.WriteLine(newMovie.title);
            Console.WriteLine(newMovie1.title);
        }
        
    }
    
}