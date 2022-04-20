using System;

namespace Books
{
    class Program
    {
        static void Main(string[] args)
        {
            //uses Book constructor to build the object book1
            Book book1 = new Book("The Name of the Wind", "Patrick Rothfuss", "Fantasy", 622, 2007);                    //creates a new Object called book1
            

            //does not use Book constructor, values are set directly
            Book book2 = new Book();                     //creates a new Object called book2
            book2.title = "The Wise Man's Fear";
            book2.author = "Patrick Rothfuss";
            book2.genre = "Fantasy";
            book2.pages =  994;
            book2.publication = 2011;

            Console.WriteLine(book1.title);
            Console.WriteLine(book2.pages);
        }
    }
}