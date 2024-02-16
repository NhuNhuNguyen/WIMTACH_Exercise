using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyCollegeV1.Migrations
{
    /// <inheritdoc />
    public partial class UpdateStudentCollegeEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CollegeRefId",
                table: "Students",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Students_CollegeRefId",
                table: "Students",
                column: "CollegeRefId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Colleges_CollegeRefId",
                table: "Students",
                column: "CollegeRefId",
                principalTable: "Colleges",
                principalColumn: "CollegeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Colleges_CollegeRefId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_CollegeRefId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CollegeRefId",
                table: "Students");
        }
    }
}
