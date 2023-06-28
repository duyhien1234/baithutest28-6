﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcMovie.Data;

#nullable disable

namespace testtest.Migrations
{
    [DbContext(typeof(MvcMovieContext))]
    partial class MvcMovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("testtest.Models.Lophoc", b =>
                {
                    b.Property<string>("Malop")
                        .HasColumnType("TEXT");

                    b.Property<string>("Siso")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Tenlop")
                        .IsRequired()
                        .HasColumnType("TEXT");
                    b.Property<string>("solop")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Malop");

                    b.ToTable("Lophoc");
                });

            modelBuilder.Entity("testtest.Models.Sinhvien", b =>
                {
                    b.Property<string>("Masinhvien")
                        .HasColumnType("TEXT");

                    b.Property<string>("Tenlop")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Tensinhvien")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Masinhvien");

                    b.HasIndex("Tenlop");

                    b.ToTable("Sinhvien");
                });

            modelBuilder.Entity("testtest.Models.Sinhvien", b =>
                {
                    b.HasOne("testtest.Models.Lophoc", "lophoc")
                        .WithMany()
                        .HasForeignKey("Tenlop")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("lophoc");
                });
#pragma warning restore 612, 618
        }
    }
}
