public interface IBookRepository
{
    Book Add(Book book);
    IEnumerable<Book> Get(int? Id = null, string? Title = null, string? Author = null, string? Genre = null, string? Language = null, int? Timeslent = null, int? Year = null, bool? Islent = null);
    Book? GetById(int id);
    Book? Remove(int id);
    Book? Update(int id, Book movie);
}
