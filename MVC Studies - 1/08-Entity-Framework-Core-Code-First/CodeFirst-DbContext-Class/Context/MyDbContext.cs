using CodeFirst_DbContext_Class.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst_DbContext_Class.Context
{
    public class MyDbContext : DbContext
    {
        // Dependency Injection yöntemi ile DB bağlantısı kurma yöntemi.
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            
        }

        // OnConfiguring metodu ile DB bağlantısı kurulur.
        // DB bağlantısı kurmak için kullanılan alternatiflerden biridir.
        // Genellikle ctor metot üzerinen DB bağlantısı kurulur ki bu yöntem daha efektifdir.
        // Aşağıdaki yöntemi de görmüş olmak için üzerinde duruyoruz.
        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=BOOKSTORE;uid:sa;pwd=123");
            base.OnConfiguring(optionsBuilder);
        }
        */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Veri tabanımızın konfigürasyonlarının yapıldığı yer OnModelCreating() metodudur.
            // Bu metor veri tabanı ilk defa oluşturulurken tetiklenir.
            // Bu metot sayesinde, veri tabanı oluşmadan önce;
            //  - Tabloların ismini değiştirebiliriz,
            //  - Kolon özelliklerini, veri tiplerini belirleyebiliriz.
        }

        // Veri tabanı ile kod üzerindeki sınıflarımız arasındaki ilişkiyi belirlemek için DbSet yazılmalıdır.
        // Böylece yazdığımız tablo sınıflarının veri tabanı üzerinde bir karşılığı olur.
        // Hazırladığımız her bir class için aşağıdaki işlemleri yapmamız gerekiyor.

        public DbSet<AppUser> Users { get; set; }
        public DbSet<AppUserDetail> UserDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
