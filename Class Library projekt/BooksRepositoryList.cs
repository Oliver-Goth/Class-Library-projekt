using System.Xml.Linq;

public class BooksRepositoryList : IBookRepository
{
    private int _nextId = 1;
    private readonly List<Book> _books = new();

    public BooksRepositoryList()
    {
        _books.Add(new Book() { Id = _nextId++, Title = "Big Book: the Original", Author = "Mr. Dumb jr.", Language = "English", Timeslent = 2148, Year = 1999, IsLent = true });
        _books.Add(new Book() { Id = _nextId++, Title = "Big Book: the Prequal", Author = "Mr. Dumb", Language = "English", Timeslent = 8265, Year = 1937, IsLent = true });
    }

    public IEnumerable<Book> Get(int? Id = null, string? Title = null, string? Author = null, string? Genre = null, string? Language = null, int? Timeslent = null, int? Year = null, bool? Islent = null)
    {
        throw new NotImplementedException();
    }

    public Book? GetById(int id)
    {
        return _books.Find(book => book.Id == id);
    }

    public Book Add(Book book)
    {
        book.Validate();
        book.Id = _nextId++;
        _books.Add(book);
        return book;
    }

    public Book? Remove(int id)
    {
        Book? book = GetById(id);
        if (book == null)
        {
            return null;
        }
        _books.Remove(book);
        return book;
    }

    public Book? Update(int id, Book book)
    {
        book.Validate();
        Book? existingBook = GetById(id);
        if (existingBook == null)
        {
            return null;
        }
        existingBook.Title = book.Title;
        existingBook.Year = book.Year;
        return existingBook;
    }
}
