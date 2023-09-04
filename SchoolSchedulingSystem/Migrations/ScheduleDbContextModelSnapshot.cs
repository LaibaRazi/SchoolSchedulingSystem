﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolSchedulingSystem.Models;

#nullable disable

namespace SchoolSchedulingSystem.Migrations
{
    [DbContext(typeof(ScheduleDbContext))]
    partial class ScheduleDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SchoolSchedulingSystem.Models.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Section")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("SchoolSchedulingSystem.Models.Teacher", b =>
                {
                    b.Property<int>("ID_Teacher")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Teacher"), 1L, 1);

                    b.Property<string>("HTeacher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeacherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("u_five")
                        .HasColumnType("int");

                    b.Property<int>("u_four")
                        .HasColumnType("int");

                    b.Property<int>("u_one")
                        .HasColumnType("int");

                    b.Property<int>("u_seven")
                        .HasColumnType("int");

                    b.Property<int>("u_six")
                        .HasColumnType("int");

                    b.Property<int>("u_three")
                        .HasColumnType("int");

                    b.Property<int>("u_two")
                        .HasColumnType("int");

                    b.HasKey("ID_Teacher");

                    b.ToTable("Teachers");
                });
#pragma warning restore 612, 618
        }
    }
}