﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PostsService.Data;

namespace PostsService.Migrations
{
    [DbContext(typeof(PostsDbContext))]
    [Migration("20210812085804_onetoonefix2")]
    partial class onetoonefix2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("PostsService.Models.DbCategory", b =>
                {
                    b.Property<string>("CategoryName")
                        .HasColumnType("text");

                    b.Property<List<string>>("AllowedUrls")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OwnerUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CategoryName");

                    b.ToTable("Dbcategories");
                });

            modelBuilder.Entity("PostsService.Models.DbPost", b =>
                {
                    b.Property<string>("PostId")
                        .HasColumnType("text");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Clouts")
                        .HasColumnType("integer");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsAd")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsFromPremium")
                        .HasColumnType("boolean");

                    b.Property<string>("OwnerUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("PostedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PostId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("PostsService.Models.PostConfiguration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("Boost")
                        .HasColumnType("integer");

                    b.Property<int?>("ColumnSize")
                        .HasColumnType("integer");

                    b.Property<bool>("HasGradient")
                        .HasColumnType("boolean");

                    b.Property<string>("PostId")
                        .HasColumnType("text");

                    b.Property<string>("PrimaryColor")
                        .HasColumnType("text");

                    b.Property<string>("SecondaryColor")
                        .HasColumnType("text");

                    b.Property<string>("TertiaryColor")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("PostId")
                        .IsUnique();

                    b.ToTable("PostConfiguration");
                });

            modelBuilder.Entity("PostsService.Models.PostConfiguration", b =>
                {
                    b.HasOne("PostsService.Models.DbPost", "Post")
                        .WithOne("PostConfiguration")
                        .HasForeignKey("PostsService.Models.PostConfiguration", "PostId")
                        .OnDelete(DeleteBehavior.ClientCascade);

                    b.Navigation("Post");
                });

            modelBuilder.Entity("PostsService.Models.DbPost", b =>
                {
                    b.Navigation("PostConfiguration");
                });
#pragma warning restore 612, 618
        }
    }
}
