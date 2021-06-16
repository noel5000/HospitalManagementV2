using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class PacientesAda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AHF",
                table: "Customers",
                maxLength: 5000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "APNP",
                table: "Customers",
                maxLength: 5000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AntecedentesPatologicos",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AntecedentesPerinatales",
                table: "Customers",
                maxLength: 5000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DesarrolloPsicomotor",
                table: "Customers",
                maxLength: 5000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Diagnosticos",
                table: "Customers",
                maxLength: 2000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Espirometria",
                table: "Customers",
                maxLength: 5000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstadoDeSalud",
                table: "Customers",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExploracionFisica",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Informante",
                table: "Customers",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PadenciaActual",
                table: "Customers",
                maxLength: 5000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Paraclinicos",
                table: "Customers",
                maxLength: 5000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PlanTerapeutico",
                table: "Customers",
                maxLength: 5000,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AHF",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "APNP",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "AntecedentesPatologicos",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "AntecedentesPerinatales",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "DesarrolloPsicomotor",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Diagnosticos",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Espirometria",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "EstadoDeSalud",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ExploracionFisica",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Informante",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PadenciaActual",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Paraclinicos",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PlanTerapeutico",
                table: "Customers");
        }
    }
}
