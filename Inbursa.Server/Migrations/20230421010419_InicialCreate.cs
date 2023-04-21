using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inbursa.Server.Migrations
{
    /// <inheritdoc />
    public partial class InicialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cuenta",
                columns: table => new
                {
                    Num_Cuenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Saldo = table.Column<float>(type: "real", nullable: false),
                    Prestamo_Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuenta", x => x.Num_Cuenta);
                });

            migrationBuilder.CreateTable(
                name: "Datos_Prestamos",
                columns: table => new
                {
                    Num_Folio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha_Solicitud = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_Aprobacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_Liquidacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_Limite = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Num_Historial = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Datos_Prestamos", x => x.Num_Folio);
                });

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    Nomina = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CURP = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.Nomina);
                });

            migrationBuilder.CreateTable(
                name: "Gerente",
                columns: table => new
                {
                    Num_Nom = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nomina = table.Column<int>(type: "int", nullable: false),
                    Dias_Vacaciones = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gerente", x => x.Num_Nom);
                });

            migrationBuilder.CreateTable(
                name: "Historial",
                columns: table => new
                {
                    Num_Historial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cantidad = table.Column<float>(type: "real", nullable: false),
                    Pago_Realizados = table.Column<int>(type: "int", nullable: false),
                    Pago_Pendientes = table.Column<int>(type: "int", nullable: false),
                    Num_Cuenta = table.Column<int>(type: "int", nullable: false),
                    Nomina_Encargado = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historial", x => x.Num_Historial);
                });

            migrationBuilder.CreateTable(
                name: "Rifa",
                columns: table => new
                {
                    Num_Boleto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cuenta = table.Column<int>(type: "int", nullable: false),
                    Fecha_Boleto = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rifa", x => x.Num_Boleto);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    CURP = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido_P = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido_M = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cumpleanos = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Contrasena = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Autorizada = table.Column<bool>(type: "bit", nullable: false),
                    Nom_Usuario = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.CURP);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cuenta");

            migrationBuilder.DropTable(
                name: "Datos_Prestamos");

            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "Gerente");

            migrationBuilder.DropTable(
                name: "Historial");

            migrationBuilder.DropTable(
                name: "Rifa");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
