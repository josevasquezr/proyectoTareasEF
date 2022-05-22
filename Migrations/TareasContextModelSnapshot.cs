﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using proyectoTareasEF;

#nullable disable

namespace proyectoTareasEF.Migrations
{
    [DbContext(typeof(TareasContext))]
    partial class TareasContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("proyectoTareasEF.Models.Categoria", b =>
                {
                    b.Property<Guid>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Peso")
                        .HasColumnType("int");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categoria", (string)null);

                    b.HasData(
                        new
                        {
                            CategoriaId = new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac23"),
                            Nombre = "Actividades Laborales",
                            Peso = 50
                        },
                        new
                        {
                            CategoriaId = new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac24"),
                            Nombre = "Actividades Personales",
                            Peso = 30
                        },
                        new
                        {
                            CategoriaId = new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac25"),
                            Nombre = "Actividades Familiares",
                            Peso = 20
                        },
                        new
                        {
                            CategoriaId = new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac26"),
                            Nombre = "Servicios Públicos",
                            Peso = 80
                        });
                });

            modelBuilder.Entity("proyectoTareasEF.Models.Tarea", b =>
                {
                    b.Property<Guid>("TareaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoriaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaHoraRecordatorio")
                        .HasColumnType("datetime2");

                    b.Property<int>("PrioridadTarea")
                        .HasColumnType("int");

                    b.Property<bool>("Recordatorio")
                        .HasColumnType("bit");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("TareaId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Tarea", (string)null);

                    b.HasData(
                        new
                        {
                            TareaId = new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac27"),
                            CategoriaId = new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac23"),
                            FechaCreacion = new DateTime(2022, 5, 22, 5, 56, 0, 39, DateTimeKind.Local).AddTicks(429),
                            PrioridadTarea = 1,
                            Recordatorio = false,
                            Titulo = "Revisión de documentación SIISAR"
                        },
                        new
                        {
                            TareaId = new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac28"),
                            CategoriaId = new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac24"),
                            FechaCreacion = new DateTime(2022, 5, 22, 5, 56, 0, 39, DateTimeKind.Local).AddTicks(450),
                            PrioridadTarea = 0,
                            Recordatorio = false,
                            Titulo = "Ver pelicula Batman en HBO"
                        },
                        new
                        {
                            TareaId = new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac29"),
                            CategoriaId = new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac25"),
                            FechaCreacion = new DateTime(2022, 5, 22, 5, 56, 0, 39, DateTimeKind.Local).AddTicks(454),
                            FechaHoraRecordatorio = new DateTime(2022, 12, 1, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            PrioridadTarea = 0,
                            Recordatorio = true,
                            Titulo = "Viaje Roatán"
                        },
                        new
                        {
                            TareaId = new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac30"),
                            CategoriaId = new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac26"),
                            FechaCreacion = new DateTime(2022, 5, 22, 5, 56, 0, 39, DateTimeKind.Local).AddTicks(562),
                            FechaHoraRecordatorio = new DateTime(2022, 5, 29, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            PrioridadTarea = 2,
                            Recordatorio = true,
                            Titulo = "Pago de energia eléctrica"
                        });
                });

            modelBuilder.Entity("proyectoTareasEF.Models.Tarea", b =>
                {
                    b.HasOne("proyectoTareasEF.Models.Categoria", "Categoria")
                        .WithMany("Tareas")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("proyectoTareasEF.Models.Categoria", b =>
                {
                    b.Navigation("Tareas");
                });
#pragma warning restore 612, 618
        }
    }
}
