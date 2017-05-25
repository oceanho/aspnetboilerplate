using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MyLearn.EntityframeworkCore.Migrations.SampleApp;

namespace MyLearn.EntityframeworkCore.Migrations.SampleApp.Migrations
{
    [DbContext(typeof(MyAppDbContext))]
    [Migration("20170524035302_AddRoleColumns")]
    partial class AddRoleColumns
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("MyLearn.Common.Authorization.Roles.PlmRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime").HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<long?>("CreatorUserId");

                    b.HasKey("Id");

                    b.ToTable("PlmRole");
                });
        }
    }
}
