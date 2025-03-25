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
        library.AddPatron(new Student { name = "Akhil", email = "akhil@usf.edu", id = "S001", major = "Business Analytics", gradYear = 2026 });
        library.AddPatron(new Student { name = "Sandeep", email = "sandeep@usf.edu", id = "S002", major = "Information Systems", gradYear = 2025 });
        library.AddPatron(new Staff { name = "Grandon Gill", email = "grandon@usf.edu", id = "ST001", position = "Librarian", department = "Library Services" });

        // Borrow books
        library.BorrowBook("ISBN222"); // Sandeep borrows "Business Insights with AI"
        library.BorrowBook("ISBN333"); // Akhil borrows "Analytics in Action"

        // Display updated book availability
        Console.WriteLine("\nUpdated Library Books:");
        library.DisplayBooks();
    }
}

