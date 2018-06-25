using Microsoft.EntityFrameworkCore.Migrations;

namespace Iamonline.Data.Migrations
{
    public partial class AddedForeignKeyRefToAddressFromSubTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_AddressCountries_AddressCountryId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_AddressProvinces_AddressProvinceId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_AddressStreets_AddressStreetId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_AddressCountryId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_AddressProvinceId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_AddressStreetId",
                table: "Addresses");

            migrationBuilder.AlterColumn<int>(
                name: "AddressStreetId",
                table: "Addresses",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AddressProvinceId",
                table: "Addresses",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AddressCountryId",
                table: "Addresses",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_AddressCountryId",
                table: "Addresses",
                column: "AddressCountryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_AddressProvinceId",
                table: "Addresses",
                column: "AddressProvinceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_AddressStreetId",
                table: "Addresses",
                column: "AddressStreetId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_AddressCountries_AddressCountryId",
                table: "Addresses",
                column: "AddressCountryId",
                principalTable: "AddressCountries",
                principalColumn: "AddressCountryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_AddressProvinces_AddressProvinceId",
                table: "Addresses",
                column: "AddressProvinceId",
                principalTable: "AddressProvinces",
                principalColumn: "AddressProvinceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_AddressStreets_AddressStreetId",
                table: "Addresses",
                column: "AddressStreetId",
                principalTable: "AddressStreets",
                principalColumn: "AddressStreetId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_AddressCountries_AddressCountryId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_AddressProvinces_AddressProvinceId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_AddressStreets_AddressStreetId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_AddressCountryId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_AddressProvinceId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_AddressStreetId",
                table: "Addresses");

            migrationBuilder.AlterColumn<int>(
                name: "AddressStreetId",
                table: "Addresses",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AddressProvinceId",
                table: "Addresses",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AddressCountryId",
                table: "Addresses",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_AddressCountryId",
                table: "Addresses",
                column: "AddressCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_AddressProvinceId",
                table: "Addresses",
                column: "AddressProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_AddressStreetId",
                table: "Addresses",
                column: "AddressStreetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_AddressCountries_AddressCountryId",
                table: "Addresses",
                column: "AddressCountryId",
                principalTable: "AddressCountries",
                principalColumn: "AddressCountryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_AddressProvinces_AddressProvinceId",
                table: "Addresses",
                column: "AddressProvinceId",
                principalTable: "AddressProvinces",
                principalColumn: "AddressProvinceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_AddressStreets_AddressStreetId",
                table: "Addresses",
                column: "AddressStreetId",
                principalTable: "AddressStreets",
                principalColumn: "AddressStreetId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
