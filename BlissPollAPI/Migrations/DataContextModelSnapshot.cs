﻿// <auto-generated />
using System;
using BlissPollAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlissPollAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlissPollAPI.Model.Choices", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Choice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PollId")
                        .HasColumnType("int");

                    b.Property<int>("Votes")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PollId");

                    b.ToTable("Choices");
                });

            modelBuilder.Entity("BlissPollAPI.Model.Poll", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Image_URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Published_At")
                        .HasColumnType("datetime2");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Thumb_URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Polls");
                });

            modelBuilder.Entity("BlissPollAPI.Model.Choices", b =>
                {
                    b.HasOne("BlissPollAPI.Model.Poll", "Poll")
                        .WithMany("Choices")
                        .HasForeignKey("PollId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Poll");
                });

            modelBuilder.Entity("BlissPollAPI.Model.Poll", b =>
                {
                    b.Navigation("Choices");
                });
#pragma warning restore 612, 618
        }
    }
}
