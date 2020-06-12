using Microsoft.EntityFrameworkCore.Migrations;

namespace apiArticulos.Migrations
{
    public partial class EduTestAPI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Store",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "article",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    price = table.Column<float>(nullable: false),
                    units = table.Column<string>(nullable: true),
                    Store_Id = table.Column<int>(nullable: false),
                    storeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_article", x => x.Id);
                    table.ForeignKey(
                        name: "FK_article_Store_storeId",
                        column: x => x.storeId,
                        principalTable: "Store",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_article_storeId",
                table: "article",
                column: "storeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "article");

            migrationBuilder.DropTable(
                name: "Store");
        }
    }
}
