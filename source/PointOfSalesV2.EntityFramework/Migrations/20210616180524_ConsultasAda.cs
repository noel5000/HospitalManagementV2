using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class ConsultasAda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ExploracionFisica",
                table: "PatientCheckups",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FC",
                table: "PatientCheckups",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FR",
                table: "PatientCheckups",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Peso",
                table: "PatientCheckups",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Sat",
                table: "PatientCheckups",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Talla",
                table: "PatientCheckups",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Temperatura",
                table: "PatientCheckups",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExploracionFisica",
                table: "PatientCheckups");

            migrationBuilder.DropColumn(
                name: "FC",
                table: "PatientCheckups");

            migrationBuilder.DropColumn(
                name: "FR",
                table: "PatientCheckups");

            migrationBuilder.DropColumn(
                name: "Peso",
                table: "PatientCheckups");

            migrationBuilder.DropColumn(
                name: "Sat",
                table: "PatientCheckups");

            migrationBuilder.DropColumn(
                name: "Talla",
                table: "PatientCheckups");

            migrationBuilder.DropColumn(
                name: "Temperatura",
                table: "PatientCheckups");
        }
    }
}
