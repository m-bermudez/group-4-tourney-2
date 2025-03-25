using System;
using System.Collections.Generic;

namespace Tourney_2
{

    public class Library
    {

        private List<Book> books;
        private List<Person> patrons;

        public Library()
        {
            books = new List<Book>();
            patrons = new List<Person>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void AddPatron(Person patron)
        {
            patrons.Add(patron);
        }

        public void DisplayBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}, Available Copies: {book.AvailableCopies}");
            }
        }

        public void DisplayPatrons()
        {
            foreach (var patron in patrons)
            {
                Console.WriteLine($"Name: {patron.Name}, Email: {patron.Email}, ID: {patron.ID}");
            }
        }

        public void BorrowBook(Person patron, string isbn)
        {
            Book book = books.Find(b => b.ISBN == isbn);
            if (book != null && book.AvailableCopies > 0)
            {
                book.AvailableCopies--;
                Console.WriteLine($"{patron.Name} borrowed {book.Title}");
            }
            else
            {
                Console.WriteLine("Book not available.");
            }
        }
    }
}
