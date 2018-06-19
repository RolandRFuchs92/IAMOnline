﻿// <auto-generated />
using System;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(SiteDb))]
    partial class SiteDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataAccess.Entities.AddressCountry", b =>
                {
                    b.Property<int>("AddressCountryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryCode");

                    b.Property<string>("CountryName");

                    b.HasKey("AddressCountryId");

                    b.ToTable("AddressCountries");
                });

            modelBuilder.Entity("DataAccess.Entities.BlogDetail", b =>
                {
                    b.Property<int>("BlogDetailId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BlogAuthor");

                    b.Property<string>("BlogBody");

                    b.Property<string>("BlogClosingCaption");

                    b.Property<string>("BlogImagePath");

                    b.Property<string>("BlogIntro");

                    b.Property<string>("BlogRemarks");

                    b.Property<DateTime>("BlogStartingDate");

                    b.Property<string>("BlogTitle");

                    b.Property<int?>("BlogTypeId");

                    b.Property<DateTime>("BlogWrittenOn");

                    b.HasKey("BlogDetailId");

                    b.HasIndex("BlogTypeId");

                    b.ToTable("BlogDetails");
                });

            modelBuilder.Entity("DataAccess.Entities.BlogType", b =>
                {
                    b.Property<int>("BlogTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BlogName");

                    b.HasKey("BlogTypeId");

                    b.ToTable("BlogTypes");
                });

            modelBuilder.Entity("DataAccess.Entities.BlogDetail", b =>
                {
                    b.HasOne("DataAccess.Entities.BlogType", "BlogType")
                        .WithMany()
                        .HasForeignKey("BlogTypeId");
                });
#pragma warning restore 612, 618
        }
    }
}
