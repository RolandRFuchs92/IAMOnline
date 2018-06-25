using Microsoft.EntityFrameworkCore.Migrations;

namespace Iamonline.Data.Migrations
{
    public partial class PlayingWithAddressEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "IX_CoreMembers_PersonId",
                table: "CoreMembers");

            migrationBuilder.DropIndex(
                name: "IX_CoreBlogs_BlogDetailId",
                table: "CoreBlogs");

            migrationBuilder.DropIndex(
                name: "IX_BlogDetails_BlogTypeId",
                table: "BlogDetails");

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
                name: "FK_CoreMembers_Clients_ClientId",
                table: "CoreMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_CoreMembers_Persons_PersonId",
                table: "CoreMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Addresses_AddressId",
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
