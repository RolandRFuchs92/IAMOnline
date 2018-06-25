using Microsoft.EntityFrameworkCore.Migrations;

namespace Iamonline.Data.Migrations
{
    public partial class AddedNullablePersonAddressref : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "Persons",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "Persons",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
