using Fluent_Validation.Configurations;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using Fluent_Validation.Models;
using Fluent_Validation.Initializer;

namespace Fluent_Validation.Context
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

        // Veri tabanımızın konfigürasyonlarının yapıldığı yer OnModelCreating() metodudur.
        // Bu metor veri tabanı ilk defa oluşturulurken tetiklenir.
        // Bu metot sayesinde, veri tabanı oluşmadan önce;
        //  - Tabloların ismini değiştirebiliriz,
        //  - Kolon özelliklerini, veri tiplerini belirleyebiliriz.
        // FLUENT API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Data Seeding

            DatabaseInitializer.Seed(modelBuilder);

            // Author

            modelBuilder.ApplyConfiguration(new AuthorConfiguration());

            // Member

            modelBuilder.ApplyConfiguration(new MemberConfiguration());

            // Reservation

            modelBuilder.ApplyConfiguration(new ReservationConfiguration());

            // Book

            modelBuilder.ApplyConfiguration(new BookConfiguration());

            // Fine

            modelBuilder.ApplyConfiguration(new FineConfiguration());

            // Fine Payment

            modelBuilder.ApplyConfiguration(new FinePaymentConfiguration());

            // Loan

            modelBuilder.ApplyConfiguration(new LoanConfiguration());
        }

        // Veri tabanı ile kod üzerindeki sınıflarımız arasındaki ilişkiyi belirlemek için DbSet yazılmalıdır.
        // Böylece yazdığımız tablo sınıflarının veri tabanı üzerinde bir karşılığı olur.
        // Hazırladığımız her bir class için aşağıdaki işlemleri yapmamız gerekiyor.

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Fine> Fines { get; set; }
        public DbSet<FinePayment> FinePayments { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ReservationStatus> ReservationStatuses { get; set; }
        public DbSet<MemberStatus> MemberStatuses { get; set; }
        public DbSet<MemberDetail> MembersDetails { get; set; }
        public DbSet<BookType> BookTypes { get; set; }
        public DbSet<AppUser> Users { get; set; }
    }
}

