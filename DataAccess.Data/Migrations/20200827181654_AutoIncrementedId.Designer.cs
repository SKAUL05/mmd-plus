﻿// <auto-generated />
using System;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DataAccess.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200827181654_AutoIncrementedId")]
    partial class AutoIncrementedId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("DataAccess.Model.Team", b =>
                {
                    b.Property<string>("TeamId")
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("LastUpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.Property<DateTime>("RegisteredAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("SecretToken")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("TeamId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("DataAccess.Model.User", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("character varying(60)")
                        .HasMaxLength(60);

                    b.Property<DateTime>("AddedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("TeamId")
                        .IsRequired()
                        .HasColumnType("character varying(60)")
                        .HasMaxLength(60);

                    b.HasKey("UserId");

                    b.HasIndex("TeamId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DataAccess.Model.User", b =>
                {
                    b.HasOne("DataAccess.Model.Team", "Team")
                        .WithMany("Users")
                        .HasForeignKey("TeamId")
                        .HasConstraintName("FK_User_Team")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
