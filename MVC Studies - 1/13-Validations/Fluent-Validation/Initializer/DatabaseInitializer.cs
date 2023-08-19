using Fluent_Validation.Enums;
using Fluent_Validation.Models;
using Microsoft.EntityFrameworkCore;

namespace Fluent_Validation.Initializer
{
    public static class DatabaseInitializer
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            string password1 = BCrypt.Net.BCrypt.HashPassword("123");
            string password2 = BCrypt.Net.BCrypt.HashPassword("123");

            modelBuilder.Entity<AppUser>()
                .HasData(
                    new AppUser()
                    {
                        Id = 1,
                        UserName = "administrator",
                        Password = password1,
                        Role = Role.Administrator
                    },
                    new AppUser()
                    {
                        Id = 2,
                        UserName = "halimcanocakli",
                        Password = password2,
                        Role = Role.User
                    });

            modelBuilder.Entity<MemberStatus>()
                .HasData(
                    new MemberStatus()
                    {
                        Id = 1,
                    },
                    new MemberStatus()
                    {
                        Id = 2,
                    },
                    new MemberStatus()
                    {
                        Id = 3,
                    },
                    new MemberStatus()
                    {
                        Id = 4,
                    });

            modelBuilder.Entity<Member>()
                .HasData(
                    new Member()
                    {
                        Id = 1,
                        MemberStatusID = 1,
                        FirstName = "Halim Can",
                        LastName = "Ocaklı",
                        Gender = Gender.Male,
                    },
                    new Member()
                    {
                        Id = 2,
                        MemberStatusID = 2,
                        FirstName = "Oğuzhan",
                        LastName = "Deniz",
                        Gender = Gender.Male,
                    },
                    new Member()
                    {
                        Id = 3,
                        MemberStatusID = 3,
                        FirstName = "Raziye",
                        LastName = "Dogan",
                        Gender = Gender.Female,
                    },
                    new Member()
                    {
                        Id = 4,
                        MemberStatusID = 4,
                        FirstName = "Batın Berkin",
                        LastName = "Topaloğlu",
                        Gender = Gender.Male,
                    });

            modelBuilder.Entity<MemberDetail>()
                .HasData(
                    new MemberDetail()
                    {
                        Id = 1,
                        MemberID = 1,
                        Email = "halimcanocakli@gmail.com",
                        PhoneNumber = "+905417694139",
                        JoinedDate = new System.DateTime(2015, 12, 03),
                    },
                    new MemberDetail()
                    {
                        Id = 2,
                        MemberID = 2,
                        Email = "oguzhandeniz@gmail.com",
                        PhoneNumber = "+905373322268",
                        JoinedDate = new System.DateTime(2016, 01, 15),
                    },
                    new MemberDetail()
                    {
                        Id = 3,
                        MemberID = 3,
                        Email = "raziyedogan@gmail.com",
                        PhoneNumber = "+05436659845",
                        JoinedDate = new System.DateTime(2017, 02, 20),
                    },
                    new MemberDetail()
                    {
                        Id = 4,
                        MemberID = 4,
                        Email = "batinberkintopaloglu@gmail.com",
                        PhoneNumber = "+05359865271",
                        JoinedDate = new System.DateTime(2018, 10, 25),
                    });
        }
    }
}
