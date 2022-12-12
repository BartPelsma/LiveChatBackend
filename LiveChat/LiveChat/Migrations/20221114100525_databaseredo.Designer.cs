﻿// <auto-generated />
using System;
using LiveChat_Backend.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LiveChat_Backend.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221114100525_databaseredo")]
    partial class databaseredo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AccountDTODialogDTO", b =>
                {
                    b.Property<int>("AccountID")
                        .HasColumnType("int");

                    b.Property<int>("DialogID")
                        .HasColumnType("int");

                    b.HasKey("AccountID", "DialogID");

                    b.HasIndex("DialogID");

                    b.ToTable("AccountDTODialogDTO");
                });

            modelBuilder.Entity("LiveChat_Backend.DTOS.AccountDTO", b =>
                {
                    b.Property<int>("AccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountID"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.HasKey("AccountID");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("LiveChat_Backend.DTOS.DialogDTO", b =>
                {
                    b.Property<int>("DialogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DialogID"), 1L, 1);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.HasKey("DialogID");

                    b.ToTable("Dialogs");
                });

            modelBuilder.Entity("LiveChat_Backend.DTOS.IntrestDTO", b =>
                {
                    b.Property<int>("IntrestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IntrestID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.HasKey("IntrestID");

                    b.ToTable("Intrests");
                });

            modelBuilder.Entity("LiveChat_Backend.DTOS.MessageDTO", b =>
                {
                    b.Property<int>("MessageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MessageID"), 1L, 1);

                    b.Property<int>("AccountID")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.Property<int>("DialogID")
                        .HasColumnType("int");

                    b.HasKey("MessageID");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("AccountDTODialogDTO", b =>
                {
                    b.HasOne("LiveChat_Backend.DTOS.DialogDTO", null)
                        .WithMany()
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LiveChat_Backend.DTOS.AccountDTO", null)
                        .WithMany()
                        .HasForeignKey("DialogID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
