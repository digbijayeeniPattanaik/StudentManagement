﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineStudentManagementSystem.Models;

namespace OnlineStudentManagementSystem.Migrations
{
    [DbContext(typeof(MyDBContext))]
    partial class MyDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("OnlineStudentManagementSystem.Models.AddressCode", b =>
                {
                    b.Property<int>("AddressCodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("City");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("State");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int")
                        .HasColumnName("ZipCode");

                    b.HasKey("AddressCodeId");

                    b.ToTable("AddressCodes");
                });

            modelBuilder.Entity("OnlineStudentManagementSystem.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AdminUserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("AdminUsername");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("Password");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("OnlineStudentManagementSystem.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("CourseName");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("OnlineStudentManagementSystem.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AddressCodeId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("StudentName");

                    b.HasKey("StudentId");

                    b.HasIndex("AddressCodeId");

                    b.HasIndex("CourseId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("OnlineStudentManagementSystem.Models.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Marks")
                        .HasColumnType("int")
                        .HasColumnName("Marks");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("SubjectName");

                    b.HasKey("SubjectId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("OnlineStudentManagementSystem.Models.SubjectEnrollment", b =>
                {
                    b.Property<int>("EnrollId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("EnrollId");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectId");

                    b.ToTable("SubjectEnrollementnts");
                });

            modelBuilder.Entity("OnlineStudentManagementSystem.Models.Student", b =>
                {
                    b.HasOne("OnlineStudentManagementSystem.Models.AddressCode", "AddressCodes")
                        .WithMany("Students")
                        .HasForeignKey("AddressCodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineStudentManagementSystem.Models.Course", "Courses")
                        .WithMany("Students")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AddressCodes");

                    b.Navigation("Courses");
                });

            modelBuilder.Entity("OnlineStudentManagementSystem.Models.SubjectEnrollment", b =>
                {
                    b.HasOne("OnlineStudentManagementSystem.Models.Student", null)
                        .WithMany("SubjectEnrollments")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineStudentManagementSystem.Models.Subject", "Subjects")
                        .WithMany("SubjectEnrollments")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("OnlineStudentManagementSystem.Models.AddressCode", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("OnlineStudentManagementSystem.Models.Course", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("OnlineStudentManagementSystem.Models.Student", b =>
                {
                    b.Navigation("SubjectEnrollments");
                });

            modelBuilder.Entity("OnlineStudentManagementSystem.Models.Subject", b =>
                {
                    b.Navigation("SubjectEnrollments");
                });
#pragma warning restore 612, 618
        }
    }
}
