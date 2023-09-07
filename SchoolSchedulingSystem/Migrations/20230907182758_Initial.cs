using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolSchedulingSystem.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    ID_Teacher = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HTeacher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    u_one = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    u_two = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    u_three = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    u_four = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    u_five = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    u_six = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    u_seven = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.ID_Teacher);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
