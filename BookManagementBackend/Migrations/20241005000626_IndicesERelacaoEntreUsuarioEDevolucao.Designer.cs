﻿// <auto-generated />
using System;
using BookManagementBackend.Infraestructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookManagementBackend.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20241005000626_IndicesERelacaoEntreUsuarioEDevolucao")]
    partial class IndicesERelacaoEntreUsuarioEDevolucao
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BookManagementBackend.Domain.Models.Books", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Author")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Genre")
                        .HasColumnType("longtext");

                    b.Property<string>("ImageLink")
                        .HasColumnType("longtext");

                    b.Property<string>("Isbn10")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Isbn13")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Language")
                        .HasColumnType("longtext");

                    b.Property<int?>("Pages")
                        .HasColumnType("int");

                    b.Property<string>("PublishedDate")
                        .HasColumnType("longtext");

                    b.Property<string>("Publisher")
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("Isbn10");

                    b.HasIndex("Isbn13");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BookManagementBackend.Domain.Models.BooksReturn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<bool>("ReturnConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ReturnUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("ReturnUserId");

                    b.ToTable("BooksReturn");
                });

            modelBuilder.Entity("BookManagementBackend.Domain.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsAdministrator")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BookManagementBackend.Domain.Models.BooksReturn", b =>
                {
                    b.HasOne("BookManagementBackend.Domain.Models.Books", "Book")
                        .WithMany("Returns")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BookManagementBackend.Domain.Models.Users", "ReturnUser")
                        .WithMany("BooksReturn")
                        .HasForeignKey("ReturnUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("ReturnUser");
                });

            modelBuilder.Entity("BookManagementBackend.Domain.Models.Books", b =>
                {
                    b.Navigation("Returns");
                });

            modelBuilder.Entity("BookManagementBackend.Domain.Models.Users", b =>
                {
                    b.Navigation("BooksReturn");
                });
#pragma warning restore 612, 618
        }
    }
}
