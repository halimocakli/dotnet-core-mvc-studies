using Microsoft.EntityFrameworkCore;
using Entities.Models;

namespace Repositories
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product>? Products { get; set; }

        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {

        }
        // Model inşaa edilirken Product tablosuna bakılacak ve eğer içinde veri yoksa OnModelCreating() metodu çalışarak 
        // modelBuilder parametresi üzerinden modele veri ekleyecek. Bu şekilde sisteme, built-in veri sağlamış oluyoruz.
        // Eğer sistemde veri varsa aşağıdaki işlemler gerçekleşmeyecek.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
            .HasData(
                new Product() { ProductId = 1, ProductName = "Computer", Price = 17_000 },
                new Product() { ProductId = 2, ProductName = "Keyboard", Price = 1_000 },
                new Product() { ProductId = 3, ProductName = "Mouse", Price = 500 },
                new Product() { ProductId = 4, ProductName = "Monitor", Price = 7_000 },
                new Product() { ProductId = 5, ProductName = "Deck", Price = 1_500 },
                new Product() { ProductId = 6, ProductName = "Camera", Price = 2_500 }
            );
        }
    }
}

