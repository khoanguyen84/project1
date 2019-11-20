using Microsoft.EntityFrameworkCore.Migrations;

namespace BTJQ.Migrations
{
    public partial class InitDBUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Student_ClassRoomId",
                table: "Student",
                column: "ClassRoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_ClassRoom_ClassRoomId",
                table: "Student",
                column: "ClassRoomId",
                principalTable: "ClassRoom",
                principalColumn: "ClassRoomId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_ClassRoom_ClassRoomId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_ClassRoomId",
                table: "Student");
        }
    }
}
