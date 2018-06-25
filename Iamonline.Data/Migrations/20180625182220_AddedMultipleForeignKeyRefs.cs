using Microsoft.EntityFrameworkCore.Migrations;

namespace Iamonline.Data.Migrations
{
    public partial class AddedMultipleForeignKeyRefs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogDetails_BlogTypes_BlogTypeId",
                table: "BlogDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_CoreBlogs_BlogDetails_BlogDetailId",
                table: "CoreBlogs");

            migrationBuilder.DropIndex(
                name: "IX_CoreBlogs_BlogDetailId",
                table: "CoreBlogs");

            migrationBuilder.DropIndex(
                name: "IX_BlogDetails_BlogTypeId",
                table: "BlogDetails");

            migrationBuilder.AddColumn<int>(
                name: "BlodDetailId",
                table: "CoreBlogs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BlogTypeID",
                table: "BlogDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CoreBlogs_BlodDetailId",
                table: "CoreBlogs",
                column: "BlodDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BlogDetails_BlogTypeID",
                table: "BlogDetails",
                column: "BlogTypeID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogDetails_BlogTypes_BlogTypeID",
                table: "BlogDetails",
                column: "BlogTypeID",
                principalTable: "BlogTypes",
                principalColumn: "BlogTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CoreBlogs_BlogDetails_BlodDetailId",
                table: "CoreBlogs",
                column: "BlodDetailId",
                principalTable: "BlogDetails",
                principalColumn: "BlogDetailId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogDetails_BlogTypes_BlogTypeID",
                table: "BlogDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_CoreBlogs_BlogDetails_BlodDetailId",
                table: "CoreBlogs");

            migrationBuilder.DropIndex(
                name: "IX_CoreBlogs_BlodDetailId",
                table: "CoreBlogs");

            migrationBuilder.DropIndex(
                name: "IX_BlogDetails_BlogTypeID",
                table: "BlogDetails");

            migrationBuilder.DropColumn(
                name: "BlodDetailId",
                table: "CoreBlogs");

            migrationBuilder.DropColumn(
                name: "BlogTypeID",
                table: "BlogDetails");

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
                name: "FK_BlogDetails_BlogTypes_BlogTypeId",
                table: "BlogDetails",
                column: "BlogTypeId",
                principalTable: "BlogTypes",
                principalColumn: "BlogTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CoreBlogs_BlogDetails_BlogDetailId",
                table: "CoreBlogs",
                column: "BlogDetailId",
                principalTable: "BlogDetails",
                principalColumn: "BlogDetailId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
