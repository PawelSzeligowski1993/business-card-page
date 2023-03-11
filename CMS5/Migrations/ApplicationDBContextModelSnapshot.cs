﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebApplication1.Data;

#nullable disable

namespace CMS5.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WebApplication1.Models.DTO.DB1_HeroBannerDTO", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("integer");

                    b.Property<string>("additional_text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("background_image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("last_mod_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("layout_position")
                        .HasColumnType("integer");

                    b.Property<string>("section_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("section_type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("user_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("hero_banners");
                });

            modelBuilder.Entity("WebApplication1.Models.DTO.DB2_ServicesDTO", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<DateTime>("last_mod_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("layout_position")
                        .HasColumnType("integer");

                    b.Property<string>("section_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("section_type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("user_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("services");
                });

            modelBuilder.Entity("WebApplication1.Models.DTO.DB2_ServicesListDTO", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("integer");

                    b.Property<string>("baner_section_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("additional_text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("services_id")
                        .HasColumnType("integer");

                    b.Property<string>("text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("services_id");

                    b.ToTable("services_list");
                });

            modelBuilder.Entity("WebApplication1.Models.DTO.DB3_AboutUsDTO", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("integer");

                    b.Property<string>("additional_text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("image1")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("image2")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("image3")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("last_mod_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("layout_position")
                        .HasColumnType("integer");

                    b.Property<string>("section_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("section_type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("user_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("about_us");
                });

            modelBuilder.Entity("WebApplication1.Models.DTO.DB4_NumbersDTO", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("integer");

                    b.Property<string>("description1")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("description2")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("last_mod_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("layout_position")
                        .HasColumnType("integer");

                    b.Property<string>("section_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("section_type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("user_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("value1")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("value2")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("numbers");
                });

            modelBuilder.Entity("WebApplication1.Models.DTO.DB5_WorkWithUsDTO", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("integer");

                    b.Property<string>("additional_text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("background_image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("last_mod_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("layout_position")
                        .HasColumnType("integer");

                    b.Property<string>("section_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("section_type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("user_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("work_with_us");
                });

            modelBuilder.Entity("WebApplication1.Models.DTO.DB6_TestimonialsDTO", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("additional_text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("last_mod_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("layout_position")
                        .HasColumnType("integer");

                    b.Property<string>("section_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("section_type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("user_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("testimonials");
                });

            modelBuilder.Entity("WebApplication1.Models.DTO.DB6_TestimonialsListDTO", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("integer");

                    b.Property<string>("author")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("author_description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("opinion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("rating")
                        .HasColumnType("integer");

                    b.Property<int>("testimonials_id")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("testimonials_id");

                    b.ToTable("testimonials_list");
                });

            modelBuilder.Entity("WebApplication1.Models.DTO.DB7_AdvantagesDTO", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<DateTime>("last_mod_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("layout_position")
                        .HasColumnType("integer");

                    b.Property<string>("section_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("section_type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("user_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("advantages");
                });

            modelBuilder.Entity("WebApplication1.Models.DTO.DB7_AdvantagesListDTO", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("integer");

                    b.Property<string>("additional_text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("advantages_id")
                        .HasColumnType("integer");

                    b.Property<string>("icon_url")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("advantages_id");

                    b.ToTable("advantages_list");
                });

            modelBuilder.Entity("WebApplication1.Models.DTO.DB2_ServicesListDTO", b =>
                {
                    b.HasOne("WebApplication1.Models.DTO.DB2_ServicesDTO", "services")
                        .WithMany()
                        .HasForeignKey("services_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("services");
                });

            modelBuilder.Entity("WebApplication1.Models.DTO.DB6_TestimonialsListDTO", b =>
                {
                    b.HasOne("WebApplication1.Models.DTO.DB6_TestimonialsDTO", "testimonials")
                        .WithMany()
                        .HasForeignKey("testimonials_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("testimonials");
                });

            modelBuilder.Entity("WebApplication1.Models.DTO.DB7_AdvantagesListDTO", b =>
                {
                    b.HasOne("WebApplication1.Models.DTO.DB7_AdvantagesDTO", "advantages")
                        .WithMany()
                        .HasForeignKey("advantages_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("advantages");
                });
#pragma warning restore 612, 618
        }
    }
}
