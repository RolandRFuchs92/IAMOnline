using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddingNewEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddressCountryId = table.Column<int>(nullable: true),
                    AddressProvinceId = table.Column<int>(nullable: true),
                    AddressStreetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_Addresses_AddressCountries_AddressCountryId",
                        column: x => x.AddressCountryId,
                        principalTable: "AddressCountries",
                        principalColumn: "AddressCountryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Addresses_AddressProvinces_AddressProvinceId",
                        column: x => x.AddressProvinceId,
                        principalTable: "AddressProvinces",
                        principalColumn: "AddressProvinceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Addresses_AddressStreets_AddressStreetId",
                        column: x => x.AddressStreetId,
                        principalTable: "AddressStreets",
                        principalColumn: "AddressStreetId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClientName = table.Column<string>(nullable: true),
                    AddressId = table.Column<int>(nullable: true),
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
                        onDelete: ReferentialAction.Restrict);
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
                    table.ForeignKey(
                        name: "FK_Persons_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CoreMembers",
                columns: table => new
                {
                    CoreMemberId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PersonId = table.Column<int>(nullable: true),
                    ClientId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreMembers", x => x.CoreMemberId);
                    table.ForeignKey(
                        name: "FK_CoreMembers_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CoreMembers_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CoreBlogs",
                columns: table => new
                {
                    CoreBlogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BlogDetailId = table.Column<int>(nullable: true),
                    CoreMemberId = table.Column<int>(nullable: true),
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CoreBlogs_CoreMembers_CoreMemberId",
                        column: x => x.CoreMemberId,
                        principalTable: "CoreMembers",
                        principalColumn: "CoreMemberId",
                        onDelete: ReferentialAction.Restrict);
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
                name: "IX_Clients_AddressId",
                table: "Clients",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_CoreBlogs_BlogDetailId",
                table: "CoreBlogs",
                column: "BlogDetailId");

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
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_AddressId",
                table: "Persons",
                column: "AddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoreBlogs");

            migrationBuilder.DropTable(
                name: "CoreMembers");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "AddressProvinces");

            migrationBuilder.DropTable(
                name: "AddressStreets");
        }
    }
}
