using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkShop1.Migrations
{
    public partial class Secondary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_enrollment_Course_CourseId",
                table: "enrollment");

            migrationBuilder.DropForeignKey(
                name: "FK_enrollment_Student_StudentId",
                table: "enrollment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_enrollment",
                table: "enrollment");

            migrationBuilder.RenameTable(
                name: "enrollment",
                newName: "Enrollment");

            migrationBuilder.RenameIndex(
                name: "IX_enrollment_StudentId",
                table: "Enrollment",
                newName: "IX_Enrollment_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_enrollment_CourseId",
                table: "Enrollment",
                newName: "IX_Enrollment_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enrollment",
                table: "Enrollment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Course_CourseId",
                table: "Enrollment",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Student_StudentId",
                table: "Enrollment",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Course_CourseId",
                table: "Enrollment");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Student_StudentId",
                table: "Enrollment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enrollment",
                table: "Enrollment");

            migrationBuilder.RenameTable(
                name: "Enrollment",
                newName: "enrollment");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollment_StudentId",
                table: "enrollment",
                newName: "IX_enrollment_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollment_CourseId",
                table: "enrollment",
                newName: "IX_enrollment_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_enrollment",
                table: "enrollment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_enrollment_Course_CourseId",
                table: "enrollment",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_enrollment_Student_StudentId",
                table: "enrollment",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
