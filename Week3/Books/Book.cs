using System;

namespace Books
{
    class Book
    {

        //creates a class called "Book" and gives it certain class attributes/parameters
        public string title;
        public string author;

        public string genre;
        public int pages;
        public int publication;


        //allows user to build Book without constructor, need to set values directly
        public Book(){}

        //Book constructor
        public Book(string aTitle, string aAuthor, string aGenre, int aPages, int aPublication)   //named a"whatever" to stand for argument
        {
            title = aTitle;
            author = aAuthor;
            genre = aGenre;
            pages = aPages;
            publication = aPublication;
        }

    }
}