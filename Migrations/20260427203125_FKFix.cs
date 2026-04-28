using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp.Migrations
{
    /// <inheritdoc />
    public partial class FKFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExMembers_Users_userID",
                table: "ExMembers");

            migrationBuilder.DropIndex(
                name: "IX_ExMembers_userID",
                table: "ExMembers");

            migrationBuilder.DropColumn(
                name: "userID",
                table: "ExMembers");

            migrationBuilder.CreateIndex(
                name: "IX_ExMembers_createdBy",
                table: "ExMembers",
                column: "createdBy");

            migrationBuilder.AddForeignKey(
                name: "FK_ExMembers_Users_createdBy",
                table: "ExMembers",
                column: "createdBy",
                principalTable: "Users",
                principalColumn: "userID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExMembers_Users_createdBy",
                table: "ExMembers");

            migrationBuilder.DropIndex(
                name: "IX_ExMembers_createdBy",
                table: "ExMembers");

            migrationBuilder.AddColumn<int>(
                name: "userID",
                table: "ExMembers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ExMembers_userID",
                table: "ExMembers",
                column: "userID");

            migrationBuilder.AddForeignKey(
                name: "FK_ExMembers_Users_userID",
                table: "ExMembers",
                column: "userID",
                principalTable: "Users",
                principalColumn: "userID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
