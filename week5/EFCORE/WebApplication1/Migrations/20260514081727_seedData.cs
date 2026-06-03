using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookPrices_BookPrices_BookPriceId",
                table: "BookPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookPrices_BookPriceId1",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_BookPriceId1",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_BookPrices_BookPriceId",
                table: "BookPrices");

            migrationBuilder.DropColumn(
                name: "BookPriceId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BookPriceId1",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BookPriceId",
                table: "BookPrices");

            migrationBuilder.CreateIndex(
                name: "IX_BookPrices_BookId",
                table: "BookPrices",
                column: "BookId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BookPrices_Books_BookId",
                table: "BookPrices",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookPrices_Books_BookId",
                table: "BookPrices");

            migrationBuilder.DropIndex(
                name: "IX_BookPrices_BookId",
                table: "BookPrices");

            migrationBuilder.AddColumn<int>(
                name: "BookPriceId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BookPriceId1",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BookPriceId",
                table: "BookPrices",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookPriceId1",
                table: "Books",
                column: "BookPriceId1");

            migrationBuilder.CreateIndex(
                name: "IX_BookPrices_BookPriceId",
                table: "BookPrices",
                column: "BookPriceId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookPrices_BookPrices_BookPriceId",
                table: "BookPrices",
                column: "BookPriceId",
                principalTable: "BookPrices",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BookPrices_BookPriceId1",
                table: "Books",
                column: "BookPriceId1",
                principalTable: "BookPrices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
