﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(NauciProgramiranjeDbContext))]
    partial class NauciProgramiranjeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Chapter.Chapter", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ChapterNumber")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.HasKey("Id");

                    b.ToTable("Chapter");
                });

            modelBuilder.Entity("Domain.Lesson.Lesson", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ChapterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("LessonNumber")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("VideoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ChapterId");

                    b.ToTable("Lesson");
                });

            modelBuilder.Entity("Domain.Question.Question", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<bool>("IsCodeQuestion")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("LessonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Prompt")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<int>("QuestionNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LessonId");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("Domain.Lesson.Lesson", b =>
                {
                    b.HasOne("Domain.Chapter.Chapter", null)
                        .WithMany()
                        .HasForeignKey("ChapterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Question.Question", b =>
                {
                    b.HasOne("Domain.Lesson.Lesson", null)
                        .WithMany()
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
