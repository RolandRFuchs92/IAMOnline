using Microsoft.EntityFrameworkCore.Migrations;

namespace Iamonline.Data.Migrations
{
    public partial class AddedInitialEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogDetails_BlogTypes_BlogTypeId",
                table: "BlogDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Addresses_AddressId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_CoreBlogs_BlogDetails_BlogDetailId",
                table: "CoreBlogs");

            migrationBuilder.DropForeignKey(
                name: "FK_CoreBlogs_CoreMembers_CoreMemberId",
                table: "CoreBlogs");

            migrationBuilder.AlterColumn<int>(
                name: "CoreMemberId",
                table: "CoreBlogs",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BlogDetailId",
                table: "CoreBlogs",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BlogTypeId",
                table: "BlogDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogDetails_BlogTypes_BlogTypeId",
                table: "BlogDetails",
                column: "BlogTypeId",
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
                name: "FK_CoreBlogs_BlogDetails_BlogDetailId",
                table: "CoreBlogs",
                column: "BlogDetailId",
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogDetails_BlogTypes_BlogTypeId",
                table: "BlogDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Addresses_AddressId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_CoreBlogs_BlogDetails_BlogDetailId",
                table: "CoreBlogs");

            migrationBuilder.DropForeignKey(
                name: "FK_CoreBlogs_CoreMembers_CoreMemberId",
                table: "CoreBlogs");

            migrationBuilder.AlterColumn<int>(
                name: "CoreMemberId",
                table: "CoreBlogs",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "BlogDetailId",
                table: "CoreBlogs",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "Clients",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "BlogTypeId",
                table: "BlogDetails",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_BlogDetails_BlogTypes_BlogTypeId",
                table: "BlogDetails",
                column: "BlogTypeId",
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
                name: "FK_CoreBlogs_BlogDetails_BlogDetailId",
                table: "CoreBlogs",
                column: "BlogDetailId",
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
        }
    }
}
