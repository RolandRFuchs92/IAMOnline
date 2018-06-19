using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Iamonline.Data.Migrations
{
    public partial class AddedMultipleNewEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "BlogDetails");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "BlogDetails");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "BlogDetails");

            migrationBuilder.CreateTable(
                name: "AddressCountries",
                columns: table => new
                {
                    AddressCountryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryName = table.Column<string>(nullable: true),
                    CountryCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressCountries", x => x.AddressCountryId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddressCountries");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "BlogDetails",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "BlogDetails",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "BlogDetails",
                nullable: false,
                defaultValue: false);
        }
    }
}
