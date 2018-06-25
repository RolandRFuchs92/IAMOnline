using Microsoft.EntityFrameworkCore.Migrations;

namespace Iamonline.Data.Migrations
{
    public partial class DisabledCascadeDelete : Migration
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
                name: "FK_BlogDetails_BlogTypes_BlogTypeID",
                table: "BlogDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Addresses_AddressId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_CoreBlogs_BlogDetails_BlodDetailId",
                table: "CoreBlogs");

            migrationBuilder.DropForeignKey(
                name: "FK_CoreBlogs_CoreMembers_CoreMemberId",
                table: "CoreBlogs");

            migrationBuilder.DropForeignKey(
                name: "FK_CoreMembers_Clients_ClientId",
                table: "CoreMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_CoreMembers_Persons_PersonId",
                table: "CoreMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Addresses_AddressId",
                table: "Persons");

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
                name: "FK_BlogDetails_BlogTypes_BlogTypeID",
                table: "BlogDetails",
                column: "BlogTypeID",
                principalTable: "BlogTypes",
                principalColumn: "BlogTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Addresses_AddressId",
                table: "Clients",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CoreBlogs_BlogDetails_BlodDetailId",
                table: "CoreBlogs",
                column: "BlodDetailId",
                principalTable: "BlogDetails",
                principalColumn: "BlogDetailId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CoreBlogs_CoreMembers_CoreMemberId",
                table: "CoreBlogs",
                column: "CoreMemberId",
                principalTable: "CoreMembers",
                principalColumn: "CoreMemberId",
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
                name: "FK_BlogDetails_BlogTypes_BlogTypeID",
                table: "BlogDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Addresses_AddressId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_CoreBlogs_BlogDetails_BlodDetailId",
                table: "CoreBlogs");

            migrationBuilder.DropForeignKey(
                name: "FK_CoreBlogs_CoreMembers_CoreMemberId",
                table: "CoreBlogs");

            migrationBuilder.DropForeignKey(
                name: "FK_CoreMembers_Clients_ClientId",
                table: "CoreMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_CoreMembers_Persons_PersonId",
                table: "CoreMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Addresses_AddressId",
                table: "Persons");

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
                name: "FK_BlogDetails_BlogTypes_BlogTypeID",
                table: "BlogDetails",
                column: "BlogTypeID",
                principalTable: "BlogTypes",
                principalColumn: "BlogTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Addresses_AddressId",
                table: "Clients",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CoreBlogs_BlogDetails_BlodDetailId",
                table: "CoreBlogs",
                column: "BlodDetailId",
                principalTable: "BlogDetails",
                principalColumn: "BlogDetailId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CoreBlogs_CoreMembers_CoreMemberId",
                table: "CoreBlogs",
                column: "CoreMemberId",
                principalTable: "CoreMembers",
                principalColumn: "CoreMemberId",
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
    }
}
