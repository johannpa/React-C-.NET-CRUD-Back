﻿// <auto-generated />
using AspNetServer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AspNetServer.Data.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("AspNetServer.Data.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(100000)
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("PostId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            PostId = 1,
                            Content = "This is post 1 and it has some very interesting content. I have also liked the video and subscibed.",
                            Title = "Post 1"
                        },
                        new
                        {
                            PostId = 2,
                            Content = "This is post 2 and it has some very interesting content. I have also liked the video and subscibed.",
                            Title = "Post 2"
                        },
                        new
                        {
                            PostId = 3,
                            Content = "This is post 3 and it has some very interesting content. I have also liked the video and subscibed.",
                            Title = "Post 3"
                        },
                        new
                        {
                            PostId = 4,
                            Content = "This is post 4 and it has some very interesting content. I have also liked the video and subscibed.",
                            Title = "Post 4"
                        },
                        new
                        {
                            PostId = 5,
                            Content = "This is post 5 and it has some very interesting content. I have also liked the video and subscibed.",
                            Title = "Post 5"
                        },
                        new
                        {
                            PostId = 6,
                            Content = "This is post 6 and it has some very interesting content. I have also liked the video and subscibed.",
                            Title = "Post 6"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
