using Microsoft.EntityFrameworkCore.Migrations;

namespace Iamonline.Data.Migrations
{
    public partial class AdjustingEntitiesForOneToOne : Migration
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

            migrationBuilder.DropForeignKey(
                name: "FK_CoreMembers_Clients_ClientId",
                table: "CoreMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_CoreMembers_Persons_PersonId",
                table: "CoreMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Addresses_AddressId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_AddressId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_CoreMembers_PersonId",
                table: "CoreMembers");

            migrationBuilder.DropIndex(
                name: "IX_CoreBlogs_BlogDetailId",
                table: "CoreBlogs");

            migrationBuilder.DropIndex(
                name: "IX_BlogDetails_BlogTypeId",
                table: "BlogDetails");

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
                name: "AddressId",
                table: "Persons",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "CoreMembers",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "CoreMembers",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

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
                name: "IX_Persons_AddressId",
                table: "Persons",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CoreMembers_PersonId",
                table: "CoreMembers",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CoreBlogs_BlogDetailId",
                table: "CoreBlogs",
                column: "BlogDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BlogDetails_BlogTypeId",
                table: "BlogDetails",
                column: "BlogTypeId",
                unique: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_CoreMembers_Clients_ClientId",
                table: "CoreMembers",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CoreMembers_Persons_PersonId",
                table: "CoreMembers",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Addresses_AddressId",
                table: "Persons",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "AddressId",
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

            migrationBuilder.DropForeignKey(
                name: "FK_CoreMembers_Clients_ClientId",
                table: "CoreMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_CoreMembers_Persons_PersonId",
                table: "CoreMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Addresses_AddressId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_AddressId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_CoreMembers_PersonId",
                table: "CoreMembers");

            migrationBuilder.DropIndex(
                name: "IX_CoreBlogs_BlogDetailId",
                table: "CoreBlogs");

            migrationBuilder.DropIndex(
                name: "IX_BlogDetails_BlogTypeId",
                table: "BlogDetails");

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
                name: "AddressId",
                table: "Persons",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "CoreMembers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "CoreMembers",
                nullable: true,
                oldClrType: typeof(int));

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
                name: "IX_Persons_AddressId",
                table: "Persons",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_CoreMembers_PersonId",
                table: "CoreMembers",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_CoreBlogs_BlogDetailId",
                table: "CoreBlogs",
                column: "BlogDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogDetails_BlogTypeId",
                table: "BlogDetails",
                column: "BlogTypeId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_CoreMembers_Clients_ClientId",
                table: "CoreMembers",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CoreMembers_Persons_PersonId",
                table: "CoreMembers",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Addresses_AddressId",
                table: "Persons",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
