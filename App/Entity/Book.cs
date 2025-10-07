namespace FirstProject.App.Entity
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublished { get; set; }

        public Book(string title, string author, int yearPublished)
        {
            Title = title;
            Author = author;
            YearPublished = yearPublished;
        }

        public bool Equals(Book book)
        {
            return this.Equals(book.Author) && this.Equals(book.Title);
        }
        
        public override string ToString()
        {
            return $"{Title} - {Author} ({YearPublished})";
        }


    }
}