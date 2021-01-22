using Microsoft.EntityFrameworkCore.Migrations;

namespace DagBok.Data.Migrations
{
    public partial class InläggIndexModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inlägg_AspNetUsers_IdUserId",
                table: "Inlägg");

            migrationBuilder.AlterColumn<string>(
                name: "IdUserId",
                table: "Inlägg",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Inlägg_AspNetUsers_IdUserId",
                table: "Inlägg",
                column: "IdUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inlägg_AspNetUsers_IdUserId",
                table: "Inlägg");

            migrationBuilder.AlterColumn<string>(
                name: "IdUserId",
                table: "Inlägg",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddForeignKey(
                name: "FK_Inlägg_AspNetUsers_IdUserId",
                table: "Inlägg",
                column: "IdUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
