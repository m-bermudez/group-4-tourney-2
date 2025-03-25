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
            Console.WriteLine($"Book added: {book.Title} by {book.Author}");
        }

        public void AddPatron(Person patron)
        {
            patrons.Add(patron);
            Console.WriteLine($"Patron added: {patron._name}");
        }

        public void DisplayBooks()
        {
            Console.WriteLine("Books in Library:");
            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}, Available Copies: {book.AvailableCopies}");
            }
        }

        public void DisplayPatrons()
        {
            Console.WriteLine("Patrons in Library:");
            foreach (var patron in patrons)
            {
                Console.WriteLine($"Name: {patron._name}, Email: {patron._email}, ID: {patron._id}");
            }
        }

        public void BorrowBook(string isbn, Person patron)
        {
            Book book = books.Find(b => b.ISBN == isbn);
            if (book != null && book.AvailableCopies > 0)
            {
                book.AvailableCopies--;
                Console.WriteLine($"{patron._name} borrowed {book.Title}");
            }
            else
            {
                Console.WriteLine("Book not available.");
            }
        }

        public void ReturnBook(string isbn, Person patron)
        {
            Book book = books.Find(b => b.ISBN == isbn);
            if (book != null)
            {
                book.AvailableCopies++;
                Console.WriteLine($"{patron._name} returned {book.Title}");
            }
            else
            {
                Console.WriteLine("Invalid book ISBN.");
            }
        }
    }
}
