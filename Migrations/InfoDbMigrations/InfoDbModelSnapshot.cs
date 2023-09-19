﻿// <auto-generated />
using Library.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Library.Migrations.InfoDbMigrations
{
    [DbContext(typeof(InfoDb))]
    partial class InfoDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("Library.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategorieId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Code")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Publisher")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategorieId");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("Library.Models.Categorie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categorie");
                });

            modelBuilder.Entity("Library.Models.Info", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("TimeIn")
                        .HasColumnType("TEXT");

                    b.Property<string>("TimeOut")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Infoss");
                });

            modelBuilder.Entity("Library.Models.Rent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DatetimeRent")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Datetimeback")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Return")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("Rent");
                });

            modelBuilder.Entity("Library.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<int>("Code")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<char>("Status")
                        .HasColumnType("TEXT");

                    b.Property<int>("Tel")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Library.Models.Book", b =>
                {
                    b.HasOne("Library.Models.Categorie", "CategorieIds")
                        .WithMany("Books")
                        .HasForeignKey("CategorieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategorieIds");
                });

            modelBuilder.Entity("Library.Models.Info", b =>
                {
                    b.HasOne("Library.Models.User", "User")
                        .WithMany("Infos")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Library.Models.Rent", b =>
                {
                    b.HasOne("Library.Models.Book", "Book")
                        .WithMany("Rents")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library.Models.User", "User")
                        .WithMany("Rents")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Library.Models.Book", b =>
                {
                    b.Navigation("Rents");
                });

            modelBuilder.Entity("Library.Models.Categorie", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Library.Models.User", b =>
                {
                    b.Navigation("Infos");

                    b.Navigation("Rents");
                });
#pragma warning restore 612, 618
        }
    }
}
