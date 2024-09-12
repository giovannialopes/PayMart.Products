using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PayMart.Infrastructure.Products.Migrations
{
    /// <inheritdoc />
    public partial class FixEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Tb_Product",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "Tb_Product",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Tb_Product",
                newName: "UpdatedBy");

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Tb_Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Tb_Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeleteBy",
                table: "Tb_Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "Tb_Product",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Tb_Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StockQuantity",
                table: "Tb_Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Tb_Product",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Tb_Product");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Tb_Product");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "Tb_Product");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "Tb_Product");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Tb_Product");

            migrationBuilder.DropColumn(
                name: "StockQuantity",
                table: "Tb_Product");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Tb_Product");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Tb_Product",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Tb_Product",
                newName: "ProductID");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Tb_Product",
                newName: "Amount");
        }
    }
}
