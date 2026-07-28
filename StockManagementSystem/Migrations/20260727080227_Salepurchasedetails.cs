using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class Salepurchasedetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Purchases_PurchaseId",
                table: "Sales");

            migrationBuilder.CreateTable(
                name: "SalePurchaseDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaleId = table.Column<int>(type: "int", nullable: false),
                    PurchaseId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    PurchasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalePurchaseDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalePurchaseDetails_Purchases_PurchaseId",
                        column: x => x.PurchaseId,
                        principalTable: "Purchases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalePurchaseDetails_Sales_SaleId",
                        column: x => x.SaleId,
                        principalTable: "Sales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SalePurchaseDetails_PurchaseId",
                table: "SalePurchaseDetails",
                column: "PurchaseId");

            migrationBuilder.CreateIndex(
                name: "IX_SalePurchaseDetails_SaleId",
                table: "SalePurchaseDetails",
                column: "SaleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Purchases_PurchaseId",
                table: "Sales",
                column: "PurchaseId",
                principalTable: "Purchases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Purchases_PurchaseId",
                table: "Sales");

            migrationBuilder.DropTable(
                name: "SalePurchaseDetails");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Purchases_PurchaseId",
                table: "Sales",
                column: "PurchaseId",
                principalTable: "Purchases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
