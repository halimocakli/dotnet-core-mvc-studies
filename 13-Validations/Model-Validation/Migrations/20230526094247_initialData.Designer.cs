﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Model_Validation.Context;

namespace Data_Seeding.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20230526094247_initialData")]
    partial class initialData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Data_Seeding.Models.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDateTime = new DateTime(2023, 5, 26, 12, 42, 47, 278, DateTimeKind.Local).AddTicks(2478),
                            Password = "$2a$11$/3QIw/ITbFEEvq9b8udpa.II2wNJrjO1LBE5ONz9.sd/bYfreW17O",
                            Role = 1,
                            Status = 1,
                            UpdatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "administrator"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDateTime = new DateTime(2023, 5, 26, 12, 42, 47, 279, DateTimeKind.Local).AddTicks(3939),
                            Password = "$2a$11$ASxt7ykC2BnleAhYs1XvPOAl8yLmtuS/iSxkrwgWlVZTNJ0OYXnyW",
                            Role = 2,
                            Status = 1,
                            UpdatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "halimcanocakli"
                        });
                });

            modelBuilder.Entity("Data_Seeding.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Isim");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Soyisim");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Yazarlar");
                });

            modelBuilder.Entity("Data_Seeding.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorID")
                        .HasColumnType("int");

                    b.Property<int>("BookTypeID")
                        .HasColumnType("int");

                    b.Property<int>("CopiesOwned")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PageCount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("PublicationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AuthorID");

                    b.HasIndex("BookTypeID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Data_Seeding.Models.BookType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TypeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("BookTypes");
                });

            modelBuilder.Entity("Data_Seeding.Models.Fine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("FineAmount")
                        .HasColumnType("numeric(18,1)");

                    b.Property<DateTime>("FineDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LoanID")
                        .HasColumnType("int");

                    b.Property<int?>("MemberID")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("LoanID");

                    b.HasIndex("MemberID");

                    b.ToTable("Fines");
                });

            modelBuilder.Entity("Data_Seeding.Models.FinePayment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("MemberID")
                        .HasColumnType("int");

                    b.Property<decimal>("PaymentAmount")
                        .HasColumnType("numeric(18,1)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MemberID");

                    b.ToTable("FinePayments");
                });

            modelBuilder.Entity("Data_Seeding.Models.Loan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LoanDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MemberID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReturnedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BookID");

                    b.HasIndex("MemberID");

                    b.ToTable("Loans");
                });

            modelBuilder.Entity("Data_Seeding.Models.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MemberStatusID")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MemberStatusID");

                    b.ToTable("Members");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDateTime = new DateTime(2023, 5, 26, 12, 42, 47, 280, DateTimeKind.Local).AddTicks(4193),
                            FirstName = "Halim Can",
                            Gender = 1,
                            LastName = "Ocaklı",
                            MemberStatusID = 1,
                            Status = 1,
                            UpdatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDateTime = new DateTime(2023, 5, 26, 12, 42, 47, 280, DateTimeKind.Local).AddTicks(5153),
                            FirstName = "Oğuzhan",
                            Gender = 1,
                            LastName = "Deniz",
                            MemberStatusID = 2,
                            Status = 1,
                            UpdatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDateTime = new DateTime(2023, 5, 26, 12, 42, 47, 280, DateTimeKind.Local).AddTicks(5158),
                            FirstName = "Raziye",
                            Gender = 2,
                            LastName = "Dogan",
                            MemberStatusID = 3,
                            Status = 1,
                            UpdatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CreatedDateTime = new DateTime(2023, 5, 26, 12, 42, 47, 280, DateTimeKind.Local).AddTicks(5160),
                            FirstName = "Batın Berkin",
                            Gender = 1,
                            LastName = "Topaloğlu",
                            MemberStatusID = 4,
                            Status = 1,
                            UpdatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Data_Seeding.Models.MemberDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("JoinedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MemberID")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MemberID")
                        .IsUnique();

                    b.ToTable("MembersDetails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDateTime = new DateTime(2023, 5, 26, 12, 42, 47, 280, DateTimeKind.Local).AddTicks(5600),
                            Email = "halimcanocakli@gmail.com",
                            JoinedDate = new DateTime(2015, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MemberID = 1,
                            PhoneNumber = "+905417694139",
                            Status = 1,
                            UpdatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDateTime = new DateTime(2023, 5, 26, 12, 42, 47, 280, DateTimeKind.Local).AddTicks(6494),
                            Email = "oguzhandeniz@gmail.com",
                            JoinedDate = new DateTime(2016, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MemberID = 2,
                            PhoneNumber = "+905373322268",
                            Status = 1,
                            UpdatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDateTime = new DateTime(2023, 5, 26, 12, 42, 47, 280, DateTimeKind.Local).AddTicks(6500),
                            Email = "raziyedogan@gmail.com",
                            JoinedDate = new DateTime(2017, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MemberID = 3,
                            PhoneNumber = "+05436659845",
                            Status = 1,
                            UpdatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CreatedDateTime = new DateTime(2023, 5, 26, 12, 42, 47, 280, DateTimeKind.Local).AddTicks(6501),
                            Email = "batinberkintopaloglu@gmail.com",
                            JoinedDate = new DateTime(2018, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MemberID = 4,
                            PhoneNumber = "+05359865271",
                            Status = 1,
                            UpdatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Data_Seeding.Models.MemberStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("StatusValue")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("MemberStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDateTime = new DateTime(2023, 5, 26, 12, 42, 47, 280, DateTimeKind.Local).AddTicks(3711),
                            Status = 1,
                            StatusValue = 0,
                            UpdatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDateTime = new DateTime(2023, 5, 26, 12, 42, 47, 280, DateTimeKind.Local).AddTicks(3718),
                            Status = 1,
                            StatusValue = 0,
                            UpdatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDateTime = new DateTime(2023, 5, 26, 12, 42, 47, 280, DateTimeKind.Local).AddTicks(3720),
                            Status = 1,
                            StatusValue = 0,
                            UpdatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CreatedDateTime = new DateTime(2023, 5, 26, 12, 42, 47, 280, DateTimeKind.Local).AddTicks(3721),
                            Status = 1,
                            StatusValue = 0,
                            UpdatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Data_Seeding.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("MemberID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ReservationStatusID")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BookID");

                    b.HasIndex("MemberID");

                    b.HasIndex("ReservationStatusID");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Data_Seeding.Models.ReservationStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("StatusValue")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ReservationStatuses");
                });

            modelBuilder.Entity("Data_Seeding.Models.Book", b =>
                {
                    b.HasOne("Data_Seeding.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data_Seeding.Models.BookType", "BookType")
                        .WithMany("Books")
                        .HasForeignKey("BookTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("BookType");
                });

            modelBuilder.Entity("Data_Seeding.Models.Fine", b =>
                {
                    b.HasOne("Data_Seeding.Models.Loan", "Loan")
                        .WithMany("Fines")
                        .HasForeignKey("LoanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data_Seeding.Models.Member", "Member")
                        .WithMany("Fines")
                        .HasForeignKey("MemberID");

                    b.Navigation("Loan");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Data_Seeding.Models.FinePayment", b =>
                {
                    b.HasOne("Data_Seeding.Models.Member", "Member")
                        .WithMany("FinePayments")
                        .HasForeignKey("MemberID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Data_Seeding.Models.Loan", b =>
                {
                    b.HasOne("Data_Seeding.Models.Book", "Book")
                        .WithMany("Loans")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data_Seeding.Models.Member", "Member")
                        .WithMany("Loans")
                        .HasForeignKey("MemberID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Data_Seeding.Models.Member", b =>
                {
                    b.HasOne("Data_Seeding.Models.MemberStatus", "MemberStatus")
                        .WithMany("Members")
                        .HasForeignKey("MemberStatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MemberStatus");
                });

            modelBuilder.Entity("Data_Seeding.Models.MemberDetail", b =>
                {
                    b.HasOne("Data_Seeding.Models.Member", "Member")
                        .WithOne("MemberDetail")
                        .HasForeignKey("Data_Seeding.Models.MemberDetail", "MemberID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Data_Seeding.Models.Reservation", b =>
                {
                    b.HasOne("Data_Seeding.Models.Book", "Book")
                        .WithMany("Reservations")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data_Seeding.Models.Member", "Member")
                        .WithMany("Reservations")
                        .HasForeignKey("MemberID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data_Seeding.Models.ReservationStatus", "ReservationStatus")
                        .WithMany("Reservations")
                        .HasForeignKey("ReservationStatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Member");

                    b.Navigation("ReservationStatus");
                });

            modelBuilder.Entity("Data_Seeding.Models.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Data_Seeding.Models.Book", b =>
                {
                    b.Navigation("Loans");

                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Data_Seeding.Models.BookType", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Data_Seeding.Models.Loan", b =>
                {
                    b.Navigation("Fines");
                });

            modelBuilder.Entity("Data_Seeding.Models.Member", b =>
                {
                    b.Navigation("FinePayments");

                    b.Navigation("Fines");

                    b.Navigation("Loans");

                    b.Navigation("MemberDetail");

                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Data_Seeding.Models.MemberStatus", b =>
                {
                    b.Navigation("Members");
                });

            modelBuilder.Entity("Data_Seeding.Models.ReservationStatus", b =>
                {
                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
