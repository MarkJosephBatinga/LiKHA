﻿// <auto-generated />
using System;
using Likha.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Likha.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220407002454_EditProductModel")]
    partial class EditProductModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Likha.Shared.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Barangay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Other")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Town")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Likha.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Paintings",
                            Url = "paintings"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Drawings",
                            Url = "drawings"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Digital Arts",
                            Url = "digital_arts"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Sculptures",
                            Url = "sculptures"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Ceramics",
                            Url = "ceramics"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Photography",
                            Url = "photography"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Designs",
                            Url = "designs"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Crafts",
                            Url = "crafts"
                        });
                });

            modelBuilder.Entity("Likha.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Artist")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArtistId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Artist = "Leonardo Da Vinci",
                            CategoryId = 1,
                            Description = "The Famous Painting of Leonardo Da Vinci",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ec/Mona_Lisa%2C_by_Leonardo_da_Vinci%2C_from_C2RMF_retouched.jpg/1200px-Mona_Lisa%2C_by_Leonardo_da_Vinci%2C_from_C2RMF_retouched.jpg",
                            Price = 29000000m,
                            Title = "Monalisa"
                        },
                        new
                        {
                            Id = 2,
                            Artist = "Juan Luna",
                            CategoryId = 2,
                            Description = "The Spoliarium is a painting by Filipino painter Juan Luna. Luna, working on canvas, spent eight months completing the painting which depicts dying gladiators.",
                            Image = "https://nolisoli.ph/wp-content/uploads/2018/08/IMG_3654.jpg",
                            Price = 3000000m,
                            Title = "Spolarium"
                        },
                        new
                        {
                            Id = 3,
                            Artist = "Vincent van Gogh",
                            CategoryId = 3,
                            Description = "The Starry Night is an oil-on-canvas painting by the Dutch Post-Impressionist painter Vincent van Gogh. Painted in June 1889,",
                            Image = "https://www.vangoghgallery.com/img/starry_night_full.jpg",
                            Price = 4000000m,
                            Title = "The Starry Night"
                        },
                        new
                        {
                            Id = 4,
                            Artist = "Vincent van Gogh",
                            CategoryId = 4,
                            Description = "Girl with a Pearl Earring is an oil painting by Dutch Golden Age painter Johannes Vermeer, dated c. 1665. ,",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0f/1665_Girl_with_a_Pearl_Earring.jpg/800px-1665_Girl_with_a_Pearl_Earring.jpg",
                            Price = 2000000m,
                            Title = "Girl with a Pearl Earring"
                        },
                        new
                        {
                            Id = 5,
                            Artist = "Pablo Picasso",
                            CategoryId = 5,
                            Description = "Guernica is a large 1937 oil painting on canvas by Spanish artist Pablo Picasso. It is one of his best-known works, regarded by many art critics as the most moving and powerful anti-war painting in history.",
                            Image = "https://upload.wikimedia.org/wikipedia/en/7/74/PicassoGuernica.jpg",
                            Price = 20000000m,
                            Title = "Guernica"
                        });
                });

            modelBuilder.Entity("Likha.Shared.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Likha.Shared.Address", b =>
                {
                    b.HasOne("Likha.Shared.User", null)
                        .WithMany("Addresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Likha.Shared.Product", b =>
                {
                    b.HasOne("Likha.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Likha.Shared.User", b =>
                {
                    b.Navigation("Addresses");
                });
#pragma warning restore 612, 618
        }
    }
}
