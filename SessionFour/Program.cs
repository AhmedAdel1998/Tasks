namespace SessionFour
{
    class Book
    {
        public string title;
        public string author;
        public string ISBN;
        public bool avilability;
        public Book(string title, string author, string ISBN, bool avilability = true)
        {
            this.title = title; this.author = author; this.ISBN = ISBN; this.avilability = avilability;
        }
        public string BookTitle
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public string BookAuthor
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        public string BookISBN
        {
            get
            {
                return ISBN;
            }
            set
            {
                ISBN = value;
            }
        }
        public bool Bookavilability
        {
            get
            {
                return avilability;
            }
            set
            {
                avilability = value;
            }
        }
    }
    class Library
    {
        List<string> collectionOfBooks = new List<string>();

        public void AddBook(Book book) { }
        public void BorrowBook(string borrowBook) { }
        public void ReturnBook(string returnBook) { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            // Adding books to the library
            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565"));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084"));
            library.AddBook(new Book("1984", "George Orwell", "9780451524935"));

            // Searching and borrowing books
            Console.WriteLine("Searching and borrowing books...");
            library.BorrowBook("Gatsby");
            library.BorrowBook("1984");
            library.BorrowBook("Harry Potter"); // This book is not in the library

            // Returning books
            Console.WriteLine("\nReturning books...");
            library.ReturnBook("Gatsby");
            library.ReturnBook("Harry Potter"); // This book is not borrowed

            Console.ReadLine();
        }
    }
}
