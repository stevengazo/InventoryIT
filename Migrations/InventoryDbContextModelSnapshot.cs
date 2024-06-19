﻿// <auto-generated />
using System;
using InventoryIT.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InventoryIT.Migrations
{
    [DbContext(typeof(InventoryDbContext))]
    partial class InventoryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("InventoryIT.Model.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BrandId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BrandId");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("InventoryIT.Model.ComputerModel", b =>
                {
                    b.Property<int>("ComputerModelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ComputerModelID"), 1L, 1);

                    b.Property<string>("AdquisitionDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("Cost")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<bool>("HasNumericKeyboard")
                        .HasColumnType("bit");

                    b.Property<bool>("HaveSSD")
                        .HasColumnType("bit");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("KeyboardLayout")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RAMType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SerialNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SizeDisk")
                        .HasColumnType("int");

                    b.Property<int>("SizeRAM")
                        .HasColumnType("int");

                    b.HasKey("ComputerModelID");

                    b.HasIndex("BrandId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Computer");
                });

            modelBuilder.Entity("InventoryIT.Model.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"), 1L, 1);

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("InventoryIT.Model.HistoryModel", b =>
                {
                    b.Property<int>("HistoryModelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HistoryModelID"), 1L, 1);

                    b.Property<int?>("ComputerModelID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SmartPhoneModelId")
                        .HasColumnType("int");

                    b.HasKey("HistoryModelID");

                    b.HasIndex("ComputerModelID");

                    b.HasIndex("SmartPhoneModelId");

                    b.ToTable("History");
                });

            modelBuilder.Entity("InventoryIT.Model.Phone_Number_User_Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("PhoneNumberId")
                        .HasColumnType("int");

                    b.Property<int?>("SmartPhoneModelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("PhoneNumberId");

                    b.HasIndex("SmartPhoneModelId");

                    b.ToTable("Phone_Number_User");
                });

            modelBuilder.Entity("InventoryIT.Model.PhoneNumber", b =>
                {
                    b.Property<int>("PhoneNumberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhoneNumberId"), 1L, 1);

                    b.Property<int>("IsActive")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Operator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PhoneNumberId");

                    b.ToTable("PhoneNumber");
                });

            modelBuilder.Entity("InventoryIT.Model.SmartPhoneModel", b =>
                {
                    b.Property<int>("SmartPhoneModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SmartPhoneModelId"), 1L, 1);

                    b.Property<DateTime>("AdquisitionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("Cost")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneSerial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("SmartPhoneModelId");

                    b.HasIndex("BrandId");

                    b.ToTable("SmartPhone");
                });

            modelBuilder.Entity("InventoryIT.Model.ComputerModel", b =>
                {
                    b.HasOne("InventoryIT.Model.Brand", "Brand")
                        .WithMany("Computers")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InventoryIT.Model.Employee", null)
                        .WithMany("computer_Models")
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("InventoryIT.Model.HistoryModel", b =>
                {
                    b.HasOne("InventoryIT.Model.ComputerModel", "ComputerModel")
                        .WithMany("Histories")
                        .HasForeignKey("ComputerModelID");

                    b.HasOne("InventoryIT.Model.SmartPhoneModel", "SmartPhoneModel")
                        .WithMany("History")
                        .HasForeignKey("SmartPhoneModelId");

                    b.Navigation("ComputerModel");

                    b.Navigation("SmartPhoneModel");
                });

            modelBuilder.Entity("InventoryIT.Model.Phone_Number_User_Model", b =>
                {
                    b.HasOne("InventoryIT.Model.Employee", "Employee")
                        .WithMany("phone_Number_User_Models")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("InventoryIT.Model.PhoneNumber", "PhoneNumber")
                        .WithMany("Phone_Number_User")
                        .HasForeignKey("PhoneNumberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InventoryIT.Model.SmartPhoneModel", "PhoneNumberModel")
                        .WithMany("Phone_Number_User_s")
                        .HasForeignKey("SmartPhoneModelId");

                    b.Navigation("Employee");

                    b.Navigation("PhoneNumber");

                    b.Navigation("PhoneNumberModel");
                });

            modelBuilder.Entity("InventoryIT.Model.SmartPhoneModel", b =>
                {
                    b.HasOne("InventoryIT.Model.Brand", "Brand")
                        .WithMany("SmartPhones")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("InventoryIT.Model.Brand", b =>
                {
                    b.Navigation("Computers");

                    b.Navigation("SmartPhones");
                });

            modelBuilder.Entity("InventoryIT.Model.ComputerModel", b =>
                {
                    b.Navigation("Histories");
                });

            modelBuilder.Entity("InventoryIT.Model.Employee", b =>
                {
                    b.Navigation("computer_Models");

                    b.Navigation("phone_Number_User_Models");
                });

            modelBuilder.Entity("InventoryIT.Model.PhoneNumber", b =>
                {
                    b.Navigation("Phone_Number_User");
                });

            modelBuilder.Entity("InventoryIT.Model.SmartPhoneModel", b =>
                {
                    b.Navigation("History");

                    b.Navigation("Phone_Number_User_s");
                });
#pragma warning restore 612, 618
        }
    }
}
