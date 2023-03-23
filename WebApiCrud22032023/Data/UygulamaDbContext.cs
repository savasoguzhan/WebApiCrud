using Microsoft.EntityFrameworkCore;

namespace WebApiCrud22032023.Data
{
    public class UygulamaDbContext : DbContext
    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options) : base(options)
        {

        }

        public DbSet<Kisi> Kisiler { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kisi>().HasData(
                new Kisi() { Id = 1, Ad = "Ali" },
                 new Kisi() { Id = 2, Ad = "Efe" },
                  new Kisi() { Id = 3, Ad = "Can" },
                   new Kisi() { Id = 4, Ad = "Ada" });
        }


    }
}
