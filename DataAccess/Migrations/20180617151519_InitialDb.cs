using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogTypes",
                columns: table => new
                {
                    BlogTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BlogName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogTypes", x => x.BlogTypeId);
                });

            migrationBuilder.CreateTable(
                name: "BlogDetails",
                columns: table => new
                {
                    BlogDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BlogImagePath = table.Column<string>(nullable: true),
                    BlogTitle = table.Column<string>(nullable: true),
                    BlogAuthor = table.Column<string>(nullable: true),
                    BlogWrittenOn = table.Column<DateTime>(nullable: false),
                    BlogIntro = table.Column<string>(nullable: true),
                    BlogBody = table.Column<string>(nullable: true),
                    BlogRemarks = table.Column<string>(nullable: true),
                    BlogClosingCaption = table.Column<string>(nullable: true),
                    BlogStartingDate = table.Column<DateTime>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    BlogTypeId = table.Column<int>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogDetails", x => x.BlogDetailId);
                    table.ForeignKey(
                        name: "FK_BlogDetails_BlogTypes_BlogTypeId",
                        column: x => x.BlogTypeId,
                        principalTable: "BlogTypes",
                        principalColumn: "BlogTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogDetails_BlogTypeId",
                table: "BlogDetails",
                column: "BlogTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogDetails");

            migrationBuilder.DropTable(
                name: "BlogTypes");
        }
    }
}
