using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ViewComponentServiceLifeTime.Migrations
{
    public partial class addBiosTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FacebookUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TwitterUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LinkedinUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstagramUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bios");
        }
    }
}
