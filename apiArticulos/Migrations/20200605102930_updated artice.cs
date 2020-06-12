using Microsoft.EntityFrameworkCore.Migrations;

namespace apiArticulos.Migrations
{
    public partial class updatedartice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Store_Id",
                table: "article");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Store_Id",
                table: "article",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
