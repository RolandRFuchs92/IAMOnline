using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Iamonline.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "AddressProvinces",
                columns: table => new
                {
                    AddressProvinceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProvinceName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressProvinces", x => x.AddressProvinceId);
                });

            migrationBuilder.CreateTable(
                name: "AddressStreets",
                columns: table => new
                {
                    AddressStreetId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StreetName = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressStreets", x => x.AddressStreetId);
                });

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
                name: "Persons",
                columns: table => new
                {
                    PersonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PersonName = table.Column<string>(nullable: true),
                    PersonSurname = table.Column<string>(nullable: true),
                    PersonIdentityNumber = table.Column<string>(nullable: true),
                    PersonEmail = table.Column<string>(nullable: true),
                    PersonMobile = table.Column<string>(nullable: true),
                    PersonHome = table.Column<string>(nullable: true),
                    PersonWork = table.Column<string>(nullable: true),
                    AddressId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddressCountryId = table.Column<int>(nullable: false),
                    AddressProvinceId = table.Column<int>(nullable: false),
                    AddressStreetId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_Addresses_AddressCountries_AddressCountryId",
                        column: x => x.AddressCountryId,
                        principalTable: "AddressCountries",
                        principalColumn: "AddressCountryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Addresses_AddressProvinces_AddressProvinceId",
                        column: x => x.AddressProvinceId,
                        principalTable: "AddressProvinces",
                        principalColumn: "AddressProvinceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Addresses_AddressStreets_AddressStreetId",
                        column: x => x.AddressStreetId,
                        principalTable: "AddressStreets",
                        principalColumn: "AddressStreetId",
                        onDelete: ReferentialAction.Cascade);
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
                    BlogTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogDetails", x => x.BlogDetailId);
                    table.ForeignKey(
                        name: "FK_BlogDetails_BlogTypes_BlogTypeId",
                        column: x => x.BlogTypeId,
                        principalTable: "BlogTypes",
                        principalColumn: "BlogTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClientName = table.Column<string>(nullable: true),
                    AddressId = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                    table.ForeignKey(
                        name: "FK_Clients_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoreMembers",
                columns: table => new
                {
                    CoreMemberId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PersonId = table.Column<int>(nullable: false),
                    ClientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreMembers", x => x.CoreMemberId);
                    table.ForeignKey(
                        name: "FK_CoreMembers_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoreMembers_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoreBlogs",
                columns: table => new
                {
                    CoreBlogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BlogDetailId = table.Column<int>(nullable: false),
                    CoreMemberId = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreBlogs", x => x.CoreBlogId);
                    table.ForeignKey(
                        name: "FK_CoreBlogs_BlogDetails_BlogDetailId",
                        column: x => x.BlogDetailId,
                        principalTable: "BlogDetails",
                        principalColumn: "BlogDetailId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoreBlogs_CoreMembers_CoreMemberId",
                        column: x => x.CoreMemberId,
                        principalTable: "CoreMembers",
                        principalColumn: "CoreMemberId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_BlogDetails_BlogTypeId",
                table: "BlogDetails",
                column: "BlogTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_AddressId",
                table: "Clients",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_CoreBlogs_BlogDetailId",
                table: "CoreBlogs",
                column: "BlogDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CoreBlogs_CoreMemberId",
                table: "CoreBlogs",
                column: "CoreMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_CoreMembers_ClientId",
                table: "CoreMembers",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_CoreMembers_PersonId",
                table: "CoreMembers",
                column: "PersonId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoreBlogs");

            migrationBuilder.DropTable(
                name: "BlogDetails");

            migrationBuilder.DropTable(
                name: "CoreMembers");

            migrationBuilder.DropTable(
                name: "BlogTypes");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "AddressCountries");

            migrationBuilder.DropTable(
                name: "AddressProvinces");

            migrationBuilder.DropTable(
                name: "AddressStreets");
        }
    }
}
