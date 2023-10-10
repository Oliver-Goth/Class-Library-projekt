public class BooksRepositoryDB : IBookRepository
{
    public Book Add(Book book)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Book> Get(int? Id = null, string? Title = null, string? Author = null, string? Genre = null, string? Language = null, int? Timeslent = null, int? Year = null, bool? Islent = null)
    {
        throw new NotImplementedException();
    }

    public Book? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Book? Remove(int id)
    {
        throw new NotImplementedException();
    }

    public Book? Update(int id, Book movie)
    {
        throw new NotImplementedException();
    }
}
