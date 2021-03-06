﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using netcoreBack;

namespace netcoreBack.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200913005211_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("netcoreBack.Models.TarjetaCredito", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CVV")
                        .HasColumnType("varchar(3)");

                    b.Property<string>("NumeroTarjeta")
                        .HasColumnType("varchar(16)");

                    b.Property<string>("Titular")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("fechaExpiracion")
                        .HasColumnType("varchar(5)");

                    b.HasKey("Id");

                    b.ToTable("tarjetaCredito");
                });
#pragma warning restore 612, 618
        }
    }
}
