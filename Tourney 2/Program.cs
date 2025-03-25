namespace Tourney_2;

class Program
{
    static void Main()
    {
        Library library = new Library();
        Console.WriteLine("\nBooks in Library:");
        // Add books
        library.AddBook(new Book("The Art of Data Strategy", "Liam Reynolds", "ISBN111", 4));
        library.AddBook(new Book("Business Insights with AI", "Olivia Carter", "ISBN222", 3));
        library.AddBook(new Book("Analytics in Action", "Nathan Brooks", "ISBN333", 6));
        library.DisplayBooks();

        // Create and add patrons
        Student akhil = new Student("Akhil", "akhil@usf.edu", "S001", "Business Analytics", 2026);
        Student sandeep = new Student("Sandeep", "sandeep@usf.edu", "S002", "Information Systems", 2025);
        Staff grandon = new Staff("Grandon Gill", "grandon@usf.edu", "ST001", "Librarian", "Library Services");

        library.AddPatron(akhil);
        library.AddPatron(sandeep);
        library.AddPatron(grandon);
        Console.WriteLine("\nPatrons in Library:");
        library.DisplayPatrons();

        Console.WriteLine("\nBorrowing book...");
        // Borrow books (pass the *objects*, not the class)
        library.BorrowBook(sandeep, "ISBN222"); // Sandeep borrows "Business Insights with AI"
        library.BorrowBook(akhil, "ISBN333");   // Akhil borrows "Analytics in Action"

        // Display updated book availability
        Console.WriteLine("\nBooks after Borrowing:");
        library.DisplayBooks();
    }
}