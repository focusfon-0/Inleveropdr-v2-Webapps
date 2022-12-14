// <auto-generated />
using System;
using Inleveropdr_v2_Webapps.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Inleveropdr_v2_Webapps.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Inleveropdr_v2_Webapps.Models.Projecten", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("beschikbaarVanaf")
                        .HasColumnType("datetime2");

                    b.Property<string>("projectCategorie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("projectNaam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("verdienstenBijAfronden")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Projecten");
                });
#pragma warning restore 612, 618
        }
    }
}
