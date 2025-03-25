namespace Tourney_2;

// Example usage
class Program
{
    static void Main()
    {
        Library library = new Library();

        // Add books
        library.AddBook(new Book("The Art of Data Strategy", "Liam Reynolds", "ISBN111", 4));
        library.AddBook(new Book("Business Insights with AI", "Olivia Carter", "ISBN222", 3));
        library.AddBook(new Book("Analytics in Action", "Nathan Brooks", "ISBN333", 6));

        // Add patrons
        library.AddPatron(new Student { _name = "Akhil", _email = "akhil@usf.edu", _id = "S001", _major = "Business Analytics", _gradYear = 2026 });
        library.AddPatron(new Student { _name = "Sandeep", _email = "sandeep@usf.edu", _id = "S002", _major = "Information Systems", _gradYear = 2025 });
        library.AddPatron(new Staff { _name = "Grandon Gill", _email = "grandon@usf.edu", _id = "ST001", _position = "Librarian", _department = "Library Services" });

        // Borrow books
        library.BorrowBook("ISBN222"); // Sandeep borrows "Business Insights with AI"
        library.BorrowBook("ISBN333"); // Akhil borrows "Analytics in Action"

        // Display updated book availability
        Console.WriteLine("\nUpdated Library Books:");
        library.DisplayBooks();
    }
}

