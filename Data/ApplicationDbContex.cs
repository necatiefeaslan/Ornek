using Microsoft.EntityFrameworkCore;
using Ornek;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options): base(options){}
    public DbSet<Ogrenci> Ogrenciler { get; set; }
    public DbSet<Sinif> Siniflar { get; set;}
    public DbSet<Ogretmen> Ogretmenler { get; set; }
}