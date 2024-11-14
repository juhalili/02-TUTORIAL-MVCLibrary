using Microsoft.EntityFrameworkCore;

public class MVCLibraryContext : DbContext
{
    public MVCLibraryContext(DbContextOptions<MVCLibraryContext> options)
        : base(options)
    {
    }

    public DbSet<MVCLibrary.Models.Book> Book { get; set; } = default!;
}
