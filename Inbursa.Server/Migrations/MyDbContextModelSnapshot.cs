﻿// <auto-generated />
using System;
using CrudBlazor.Server.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Inbursa.Server.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Inbursa.Server.Models.Cuenta", b =>
                {
                    b.Property<int>("Num_Cuenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Num_Cuenta"));

                    b.Property<bool>("Prestamo_Activo")
                        .HasColumnType("bit");

                    b.Property<float>("Saldo")
                        .HasColumnType("real");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Num_Cuenta");

                    b.ToTable("Cuenta");
                });

            modelBuilder.Entity("Inbursa.Server.Models.Datos_Prestamos", b =>
                {
                    b.Property<int>("Num_Folio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Num_Folio"));

                    b.Property<DateTime>("Fecha_Aprobacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Fecha_Limite")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Fecha_Liquidacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Fecha_Solicitud")
                        .HasColumnType("datetime2");

                    b.Property<int>("Num_Historial")
                        .HasColumnType("int");

                    b.HasKey("Num_Folio");

                    b.ToTable("Datos_Prestamos");
                });

            modelBuilder.Entity("Inbursa.Server.Models.Empleado", b =>
                {
                    b.Property<int>("Nomina")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Nomina"));

                    b.Property<string>("CURP")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Nomina");

                    b.ToTable("Empleado");
                });

            modelBuilder.Entity("Inbursa.Server.Models.Gerente", b =>
                {
                    b.Property<int>("Num_Nom")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Num_Nom"));

                    b.Property<int>("Dias_Vacaciones")
                        .HasColumnType("int");

                    b.Property<int>("Nomina")
                        .HasColumnType("int");

                    b.HasKey("Num_Nom");

                    b.ToTable("Gerente");
                });

            modelBuilder.Entity("Inbursa.Server.Models.Historial", b =>
                {
                    b.Property<int>("Num_Historial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Num_Historial"));

                    b.Property<float>("Cantidad")
                        .HasColumnType("real");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<int>("Nomina_Encargado")
                        .HasColumnType("int");

                    b.Property<int>("Num_Cuenta")
                        .HasColumnType("int");

                    b.Property<int>("Pago_Pendientes")
                        .HasColumnType("int");

                    b.Property<int>("Pago_Realizados")
                        .HasColumnType("int");

                    b.HasKey("Num_Historial");

                    b.ToTable("Historial");
                });

            modelBuilder.Entity("Inbursa.Server.Models.Rifa", b =>
                {
                    b.Property<int>("Num_Boleto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Num_Boleto"));

                    b.Property<int>("Cuenta")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha_Boleto")
                        .HasColumnType("datetime2");

                    b.HasKey("Num_Boleto");

                    b.ToTable("Rifa");
                });

            modelBuilder.Entity("Inbursa.Server.Models.Usuario", b =>
                {
                    b.Property<string>("CURP")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Apellido_M")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Apellido_P")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Autorizada")
                        .HasColumnType("bit");

                    b.Property<string>("Contrasena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Cumpleanos")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nom_Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CURP");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
