using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Keyboard_Cats.Migrations
{
    public partial class Cats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CatEntityContact",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatEntityContact", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "Cats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cats_CatEntityContact_ContactId",
                        column: x => x.ContactId,
                        principalTable: "CatEntityContact",
                        principalColumn: "ContactId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CatEntityPhotos",
                columns: table => new
                {
                    PhotosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Small = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Medium = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Large = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Full = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CatEntityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatEntityPhotos", x => x.PhotosId);
                    table.ForeignKey(
                        name: "FK_CatEntityPhotos_Cats_CatEntityId",
                        column: x => x.CatEntityId,
                        principalTable: "Cats",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CatEntityPhotos_CatEntityId",
                table: "CatEntityPhotos",
                column: "CatEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Cats_ContactId",
                table: "Cats",
                column: "ContactId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CatEntityPhotos");

            migrationBuilder.DropTable(
                name: "Cats");

            migrationBuilder.DropTable(
                name: "CatEntityContact");
        }
    }
}
