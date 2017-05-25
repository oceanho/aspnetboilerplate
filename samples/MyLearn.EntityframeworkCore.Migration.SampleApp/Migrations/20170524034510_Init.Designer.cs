using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MyLearn.EntityframeworkCore.Migrations.SampleApp;

namespace MyLearn.EntityframeworkCore.Migrations.SampleApp.Migrations
{
    [DbContext(typeof(MyAppDbContext))]
    [Migration("20170524034510_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("MyLearn.Common.Authorization.Roles.PlmRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("PlmRole");
                });
        }
    }
}
