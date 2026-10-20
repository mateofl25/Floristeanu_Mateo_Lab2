using Microsoft.EntityFrameworkCore;

public class Floristeanu_Mateo_Lab2Context(DbContextOptions<Floristeanu_Mateo_Lab2Context> options) : DbContext(options)
{
    public DbSet<Floristeanu_Mateo_Lab2.Models.Book> Book { get; set; } = default!;
}
