using Microsoft.EntityFrameworkCore.Migrations;

namespace Dotnet_rpg.Migrations
{
    public partial class User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_User_UsersId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_UsersId",
                table: "Characters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Characters");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Users",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "PsswordHash",
                table: "Users",
                newName: "PasswordHash");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "User",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "User",
                newName: "PsswordHash");

            migrationBuilder.AddColumn<int>(
                name: "UsersId",
                table: "Characters",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_UsersId",
                table: "Characters",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_User_UsersId",
                table: "Characters",
                column: "UsersId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
