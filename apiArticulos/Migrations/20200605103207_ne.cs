using Microsoft.EntityFrameworkCore.Migrations;

namespace apiArticulos.Migrations
{
    public partial class ne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_article_Store_storeId",
                table: "article");

            migrationBuilder.AlterColumn<int>(
                name: "storeId",
                table: "article",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_article_Store_storeId",
                table: "article",
                column: "storeId",
                principalTable: "Store",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_article_Store_storeId",
                table: "article");

            migrationBuilder.AlterColumn<int>(
                name: "storeId",
                table: "article",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_article_Store_storeId",
                table: "article",
                column: "storeId",
                principalTable: "Store",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
