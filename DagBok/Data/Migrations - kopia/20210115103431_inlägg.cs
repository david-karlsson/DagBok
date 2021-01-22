using Microsoft.EntityFrameworkCore.Migrations;

namespace DagBok.Data.Migrations
{
    public partial class inlägg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inlägg",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datum = table.Column<string>(nullable: true),
                    Innehåll = table.Column<string>(nullable: true),
                    IdUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inlägg", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inlägg_AspNetUsers_IdUserId",
                        column: x => x.IdUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inlägg_IdUserId",
                table: "Inlägg",
                column: "IdUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inlägg");
        }
    }
}
