﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotnet_ef_core.DataContext;

#nullable disable

namespace dotnet_ef_core.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("dotnet_ef_core.DataContext.AdminEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("admin_email");

                    b.Property<int>("IdAudit")
                        .HasColumnType("int")
                        .HasColumnName("IdAudit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("admin_name");

                    b.Property<int>("Role")
                        .HasColumnType("int")
                        .HasColumnName("admin_role");

                    b.HasKey("Id");

                    b.ToTable("tbl_admin");
                });

            modelBuilder.Entity("dotnet_ef_core.DataContext.AssetEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("asset_name");

                    b.Property<int>("PurchaseYear")
                        .HasColumnType("int")
                        .HasColumnName("asset_purchase_year");

                    b.Property<string>("SerialNumber")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("asset_serial_number");

                    b.Property<string>("Specification")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("asset_specification");

                    b.HasKey("Id");

                    b.ToTable("tbl_asset");
                });

            modelBuilder.Entity("dotnet_ef_core.DataContext.AuditEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<bool>("AntiVirus")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("anti_virus");

                    b.Property<string>("Condition")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("condition");

                    b.Property<int>("IdAsset")
                        .HasColumnType("int")
                        .HasColumnName("asset_id");

                    b.Property<bool>("OfficeLicense")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("office_license");

                    b.Property<string>("Validation")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("validation");

                    b.Property<bool>("WindowsLicense")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("windows_license");

                    b.HasKey("Id");

                    b.ToTable("tbl_audit");
                });

            modelBuilder.Entity("dotnet_ef_core.DataContext.CategoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("CategoryCode")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("category_code");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("category_name");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.HasKey("Id");

                    b.ToTable("tbl_category");
                });

            modelBuilder.Entity("dotnet_ef_core.DataContext.EmployeeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("employee_address");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("employee_email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("employee_name");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("employee_number");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("employee_position");

                    b.HasKey("Id");

                    b.ToTable("tbl_employee");
                });

            modelBuilder.Entity("dotnet_ef_core.DataContext.RequestEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("IdAsset")
                        .HasColumnType("int")
                        .HasColumnName("asset_id");

                    b.Property<string>("Necessary")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("necessary");

                    b.Property<string>("PicId")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("pic_id");

                    b.Property<string>("SpecificationReq")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("specificationRequest");

                    b.HasKey("Id");

                    b.ToTable("tbl_request");
                });
#pragma warning restore 612, 618
        }
    }
}
