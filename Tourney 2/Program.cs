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
        library.AddPatron(new Student { Name = "Akhil", Email = "akhil@usf.edu", ID = "S001", Major = "Business Analytics", GraduationYear = 2026 });
        library.AddPatron(new Student { Name = "Sandeep", Email = "sandeep@usf.edu", ID = "S002", Major = "Information Systems", GraduationYear = 2025 });
        library.AddPatron(new Staff { Name = "Grandon Gill", Email = "grandon@usf.edu", ID = "ST001", Position = "Librarian", Department = "Library Services" });

        // Borrow books
        library.BorrowBook("ISBN222"); // Sandeep borrows "Business Insights with AI"
        library.BorrowBook("ISBN333"); // Akhil borrows "Analytics in Action"

        // Display updated book availability
        Console.WriteLine("\nUpdated Library Books:");
        library.DisplayBooks();
    }
}

