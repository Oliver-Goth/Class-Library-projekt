using System.Net.Http.Headers;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public string Language { get; set; }
    public int Timeslent { get; set; }
    public int Year { get; set; }
    public bool IsLent { get; set; }

    public void ValidateId()
    {
        if (Id == null)
        {
            throw new ArgumentNullException("id", "Id cannot be null");
        }
    }

    public void ValidateTitle()
    {

        if (Title == null)
        {
            throw new ArgumentNullException(nameof(Title), "Title cannot be null");
        }
        if (Title.Length < 1)
        {
            throw new ArgumentException("Title must be at least 1 character", nameof(Title));
        }
    }

    public void ValidateAuthor()
    {
        if (Author == null)
        {
            throw new ArgumentNullException(nameof(Author), "Author cannot be null");
        }
        if (Author.Length < 1)
        {
            throw new ArgumentException("Authors name must be at least 1 character", nameof(Author));
        }
    }

    public void ValidateGenre()
    {
        if (Genre == null)
        {
            throw new ArgumentNullException(nameof(Genre), "Genre cannot be null");
        }
        if (Genre.Length < 1)
        {
            throw new ArgumentException("Genre name must be at least 1 character", nameof(Genre));
        }
    }

    public void ValidateLanguage()
    {
        if (Language == null)
        {
            throw new ArgumentNullException(nameof(Language), "Language cannot be null");
        }
        if (Language.Length < 2)
        {
            throw new ArgumentException("Language must be at least 2 character", nameof(Language));
        }
    }

    public void ValidateTimeslent()
    {
        if (Timeslent == null)
        {
            throw new ArgumentNullException(nameof(Timeslent), "Timeslent cannot be null");
        }
    }

    public void ValidateYear()
    {
        if (Year < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(Year), "Year must be at least 0");
        }
    }

    public void Validate()
    {
        ValidateId();
        ValidateTitle();
        ValidateAuthor();
        ValidateGenre();
        ValidateLanguage();
        ValidateTimeslent();
        ValidateYear();
    }
}
