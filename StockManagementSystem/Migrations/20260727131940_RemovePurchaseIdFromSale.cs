using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class RemovePurchaseIdFromSale : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Purchases_PurchaseId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_PurchaseId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "PurchaseId",
                table: "Sales");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PurchaseId",
                table: "Sales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sales_PurchaseId",
                table: "Sales",
                column: "PurchaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Purchases_PurchaseId",
                table: "Sales",
                column: "PurchaseId",
                principalTable: "Purchases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
