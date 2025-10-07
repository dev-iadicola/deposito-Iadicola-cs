namespace FirstProject.App.Terminal;

using App.Entity;
using FirstProject.App.Helpers.Array;

class BookTerminal
{
    Book book1;
    Book book2;
    Book book3;
    public BookTerminal()
    {
    
        this.book1 = new Book("Il Signore degli Anelli", "J.R.R. Tolkien", 1954);
        this.book2 = new Book("Il Signore degli Anelli", "J.R.R. Tolkien", 1954);
        this.book3 = new Book("1984", "George Orwell", 1949);

    }

    public void equalsTest()
    {
        System.Console.WriteLine($" {this.book1.Title} = {this.book2.Title} {book1.Equals(book2)}");
        System.Console.WriteLine($" {this.book3.Title} = {this.book1.Title}    {book3.Equals(book1)}");
    }

    public void print()
    {
        Book[] books = [book1, book2, book3];
        foreach (Book book in books)
        {
            System.Console.WriteLine(book.ToString());
        }
    }
}