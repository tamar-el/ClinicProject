using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace clinicProject.data.Migrations
{
    /// <inheritdoc />
    public partial class manytomany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClassDoctorClassPatient",
                columns: table => new
                {
                    doctorsid = table.Column<int>(type: "int", nullable: false),
                    patientsid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassDoctorClassPatient", x => new { x.doctorsid, x.patientsid });
                    table.ForeignKey(
                        name: "FK_ClassDoctorClassPatient_doctors_doctorsid",
                        column: x => x.doctorsid,
                        principalTable: "doctors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassDoctorClassPatient_patients_patientsid",
                        column: x => x.patientsid,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClassDoctorClassPatient_patientsid",
                table: "ClassDoctorClassPatient",
                column: "patientsid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassDoctorClassPatient");
        }
    }
}
