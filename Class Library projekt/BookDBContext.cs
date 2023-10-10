using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
// NuGet package Microsoft.EntityFrameworkCore.SqlServer

public class BooksDbContext : DbContext
{
    public BookDbContext(DbContextOptions<BooksDbContext> options) : base(options) { }

    public DbSet<Book> Books { get; set; }
}