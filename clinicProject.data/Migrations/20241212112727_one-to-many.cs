using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace clinicProject.data.Migrations
{
    /// <inheritdoc />
    public partial class onetomany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "doctorid",
                table: "routes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "patientid",
                table: "routes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_routes_doctorid",
                table: "routes",
                column: "doctorid");

            migrationBuilder.CreateIndex(
                name: "IX_routes_patientid",
                table: "routes",
                column: "patientid");

            migrationBuilder.AddForeignKey(
                name: "FK_routes_doctors_doctorid",
                table: "routes",
                column: "doctorid",
                principalTable: "doctors",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_routes_patients_patientid",
                table: "routes",
                column: "patientid",
                principalTable: "patients",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_routes_doctors_doctorid",
                table: "routes");

            migrationBuilder.DropForeignKey(
                name: "FK_routes_patients_patientid",
                table: "routes");

            migrationBuilder.DropIndex(
                name: "IX_routes_doctorid",
                table: "routes");

            migrationBuilder.DropIndex(
                name: "IX_routes_patientid",
                table: "routes");

            migrationBuilder.DropColumn(
                name: "doctorid",
                table: "routes");

            migrationBuilder.DropColumn(
                name: "patientid",
                table: "routes");
        }
    }
}
