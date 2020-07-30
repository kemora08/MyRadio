using Microsoft.EntityFrameworkCore.Migrations;

namespace MyRadio.Infrastructure.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Frequency = table.Column<string>(nullable: true),
                    CallSign = table.Column<string>(nullable: true),
                    Genre = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stations", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "CallSign", "Frequency", "Genre", "Website" },
                values: new object[] { 1, "KHBK", "93.7", "Top 40", "HOT 93-7.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stations");
        }
    }
}
