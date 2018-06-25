﻿// <auto-generated />
using System;
using Iamonline.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Iamonline.Data.Migrations
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

            modelBuilder.Entity("Iamonline.Data.Entities.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressCountryId");

                    b.Property<int>("AddressProvinceId");

                    b.Property<int>("AddressStreetId");

                    b.HasKey("AddressId");

                    b.HasIndex("AddressCountryId")
                        .IsUnique();

                    b.HasIndex("AddressProvinceId")
                        .IsUnique();

                    b.HasIndex("AddressStreetId")
                        .IsUnique();

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Iamonline.Data.Entities.AddressCountry", b =>
                {
                    b.Property<int>("AddressCountryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryCode");

                    b.Property<string>("CountryName");

                    b.HasKey("AddressCountryId");

                    b.ToTable("AddressCountries");
                });

            modelBuilder.Entity("Iamonline.Data.Entities.AddressProvince", b =>
                {
                    b.Property<int>("AddressProvinceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProvinceName");

                    b.HasKey("AddressProvinceId");

                    b.ToTable("AddressProvinces");
                });

            modelBuilder.Entity("Iamonline.Data.Entities.AddressStreet", b =>
                {
                    b.Property<int>("AddressStreetId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PostalCode");

                    b.Property<string>("StreetName");

                    b.HasKey("AddressStreetId");

                    b.ToTable("AddressStreets");
                });

            modelBuilder.Entity("Iamonline.Data.Entities.BlogDetail", b =>
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

                    b.Property<int>("BlogTypeID");

                    b.Property<int>("BlogTypeId");

                    b.Property<DateTime>("BlogWrittenOn");

                    b.HasKey("BlogDetailId");

                    b.HasIndex("BlogTypeID")
                        .IsUnique();

                    b.ToTable("BlogDetails");
                });

            modelBuilder.Entity("Iamonline.Data.Entities.BlogType", b =>
                {
                    b.Property<int>("BlogTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BlogName");

                    b.HasKey("BlogTypeId");

                    b.ToTable("BlogTypes");
                });

            modelBuilder.Entity("Iamonline.Data.Entities.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressId");

                    b.Property<string>("ClientName");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("IsActive");

                    b.HasKey("ClientId");

                    b.HasIndex("AddressId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Iamonline.Data.Entities.CoreBlog", b =>
                {
                    b.Property<int>("CoreBlogId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlodDetailId");

                    b.Property<int>("BlogDetailId");

                    b.Property<int>("CoreMemberId");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.HasKey("CoreBlogId");

                    b.HasIndex("BlodDetailId")
                        .IsUnique();

                    b.HasIndex("CoreMemberId");

                    b.ToTable("CoreBlogs");
                });

            modelBuilder.Entity("Iamonline.Data.Entities.CoreMember", b =>
                {
                    b.Property<int>("CoreMemberId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId");

                    b.Property<int>("PersonId");

                    b.HasKey("CoreMemberId");

                    b.HasIndex("ClientId");

                    b.HasIndex("PersonId")
                        .IsUnique();

                    b.ToTable("CoreMembers");
                });

            modelBuilder.Entity("Iamonline.Data.Entities.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AddressId");

                    b.Property<string>("PersonEmail");

                    b.Property<string>("PersonHome");

                    b.Property<string>("PersonIdentityNumber");

                    b.Property<string>("PersonMobile");

                    b.Property<string>("PersonName");

                    b.Property<string>("PersonSurname");

                    b.Property<string>("PersonWork");

                    b.HasKey("PersonId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("Iamonline.Data.Entities.Address", b =>
                {
                    b.HasOne("Iamonline.Data.Entities.AddressCountry", "AddressCountry")
                        .WithOne("Address")
                        .HasForeignKey("Iamonline.Data.Entities.Address", "AddressCountryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Iamonline.Data.Entities.AddressProvince", "AddressProvince")
                        .WithOne("Address")
                        .HasForeignKey("Iamonline.Data.Entities.Address", "AddressProvinceId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Iamonline.Data.Entities.AddressStreet", "AddressStreet")
                        .WithOne("Address")
                        .HasForeignKey("Iamonline.Data.Entities.Address", "AddressStreetId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Iamonline.Data.Entities.BlogDetail", b =>
                {
                    b.HasOne("Iamonline.Data.Entities.BlogType", "BlogType")
                        .WithOne("BlogDetail")
                        .HasForeignKey("Iamonline.Data.Entities.BlogDetail", "BlogTypeID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Iamonline.Data.Entities.Client", b =>
                {
                    b.HasOne("Iamonline.Data.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Iamonline.Data.Entities.CoreBlog", b =>
                {
                    b.HasOne("Iamonline.Data.Entities.BlogDetail", "BlogDetail")
                        .WithOne("CoreBlog")
                        .HasForeignKey("Iamonline.Data.Entities.CoreBlog", "BlodDetailId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Iamonline.Data.Entities.CoreMember", "CoreMember")
                        .WithMany()
                        .HasForeignKey("CoreMemberId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Iamonline.Data.Entities.CoreMember", b =>
                {
                    b.HasOne("Iamonline.Data.Entities.Client", "Client")
                        .WithMany("CoreMembers")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Iamonline.Data.Entities.Person", "Person")
                        .WithOne("CoreMember")
                        .HasForeignKey("Iamonline.Data.Entities.CoreMember", "PersonId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
