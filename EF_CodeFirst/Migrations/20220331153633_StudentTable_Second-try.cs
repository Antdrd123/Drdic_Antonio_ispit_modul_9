using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_CodeFirst.Migrations
{
    public partial class StudentTable_Secondtry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nchar(200)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime", nullable: false),
                    Height = table.Column<decimal>(type: "decimal", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    GradeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradeName = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Section = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.GradeID);
                    table.ForeignKey(
                        name: "FK_Grades_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "DateOfBirth", "Height", "StudentName", "Weight" },
                values: new object[] { 1, new DateTime(1998, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 187.72m, "Marko", 85.720001220703125 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "DateOfBirth", "Height", "StudentName", "Weight" },
                values: new object[] { 2, new DateTime(1994, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 168.7m, "Ana", 57.75 });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "GradeID", "GradeName", "Section", "StudentId" },
                values: new object[,]
                {
                    { 1, "Excellent", "Biology", 1 },
                    { 2, "Very good", "Biology", 1 },
                    { 3, "Good", "Chemistry", 1 },
                    { 4, "Enough", "English", 1 },
                    { 5, "Excellent", "Geography", 2 },
                    { 6, "Very good", "Latin", 2 },
                    { 7, "Bad", "Mathematics", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Grades_StudentId",
                table: "Grades",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
