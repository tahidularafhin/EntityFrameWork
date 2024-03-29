﻿// <auto-generated />
using System;
using EntityFrameWork1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityFrameWork1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190704091928_AddTest")]
    partial class AddTest
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityFrameWork1.Models.Assignment", b =>
                {
                    b.Property<int>("AssignmentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AssignmentName");

                    b.HasKey("AssignmentId");

                    b.ToTable("Assignment");
                });

            modelBuilder.Entity("EntityFrameWork1.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseName");

                    b.HasKey("CourseId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("EntityFrameWork1.Models.Grade", b =>
                {
                    b.Property<int>("GradeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GradeName");

                    b.Property<string>("Section");

                    b.HasKey("GradeId");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("EntityFrameWork1.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AssignmentId");

                    b.Property<int?>("CourseId");

                    b.Property<DateTime?>("DateOfBirth");

                    b.Property<int?>("GradeId");

                    b.Property<decimal>("Height");

                    b.Property<byte[]>("Photo");

                    b.Property<string>("StudentName");

                    b.Property<int?>("TeacherId");

                    b.Property<float>("Weight");

                    b.HasKey("StudentID");

                    b.HasIndex("AssignmentId");

                    b.HasIndex("CourseId");

                    b.HasIndex("GradeId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("EntityFrameWork1.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AssignmentId");

                    b.Property<int?>("CourseId");

                    b.Property<string>("TeacherName");

                    b.HasKey("TeacherId");

                    b.HasIndex("AssignmentId");

                    b.HasIndex("CourseId");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("EntityFrameWork1.Models.Student", b =>
                {
                    b.HasOne("EntityFrameWork1.Models.Assignment")
                        .WithMany("Students")
                        .HasForeignKey("AssignmentId");

                    b.HasOne("EntityFrameWork1.Models.Course")
                        .WithMany("Students")
                        .HasForeignKey("CourseId");

                    b.HasOne("EntityFrameWork1.Models.Grade", "Grade")
                        .WithMany("Students")
                        .HasForeignKey("GradeId");

                    b.HasOne("EntityFrameWork1.Models.Teacher")
                        .WithMany("Students")
                        .HasForeignKey("TeacherId");
                });

            modelBuilder.Entity("EntityFrameWork1.Models.Teacher", b =>
                {
                    b.HasOne("EntityFrameWork1.Models.Assignment")
                        .WithMany("Teachers")
                        .HasForeignKey("AssignmentId");

                    b.HasOne("EntityFrameWork1.Models.Course")
                        .WithMany("Teachers")
                        .HasForeignKey("CourseId");
                });
#pragma warning restore 612, 618
        }
    }
}
