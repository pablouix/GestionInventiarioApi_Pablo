// <auto-generated />
using GestionInventiarioApi_Pablo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestionInventiarioApi_Pablo.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20221005191056_AddArticulosTable")]
    partial class AddArticulosTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("GestionInventiarioApi_Pablo.Models.Articulos", b =>
                {
                    b.Property<int>("articuloId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("existencia")
                        .HasColumnType("REAL");

                    b.Property<string>("marca")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("articuloId");

                    b.ToTable("Articulos");
                });
#pragma warning restore 612, 618
        }
    }
}
