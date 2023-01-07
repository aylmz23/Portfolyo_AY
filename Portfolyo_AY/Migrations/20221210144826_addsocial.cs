using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolyo_AY.Migrations
{
    public partial class addsocial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Socials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    twitter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    facebook = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    instagram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    skype = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    linkedin = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Socials", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Socials");
        }
    }
}
