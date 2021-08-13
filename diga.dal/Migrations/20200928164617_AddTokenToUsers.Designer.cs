﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;


namespace diga.dal.Migrations
{
    [DbContext(typeof(DigaContext))]
    [Migration("20200928164617_AddTokenToUsers")]
    partial class AddTokenToUsers
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("diga.web.Models.Advantages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LongTextId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortTextId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TitleTextId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("LongTextId");

                    b.HasIndex("ShortTextId");

                    b.HasIndex("TitleTextId");

                    b.ToTable("Advantages");
                });

            modelBuilder.Entity("diga.web.Models.Articles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("TextId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TitleTextId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("TextId");

                    b.HasIndex("TitleTextId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("diga.web.Models.Cases", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LongTextId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ReviewFileUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReviewVideoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortTextId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TitleTextId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("LongTextId");

                    b.HasIndex("ShortTextId");

                    b.HasIndex("TitleTextId");

                    b.ToTable("Cases");
                });

            modelBuilder.Entity("diga.web.Models.Functions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BigTitleTextId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool?>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("FullDescriptionTextId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LongTextId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("ModuleId")
                        .HasColumnType("int");

                    b.Property<string>("PictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SmallTitleTextId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BigTitleTextId");

                    b.HasIndex("FullDescriptionTextId");

                    b.HasIndex("LongTextId");

                    b.HasIndex("ModuleId");

                    b.HasIndex("SmallTitleTextId");

                    b.ToTable("Functions");
                });

            modelBuilder.Entity("diga.web.Models.ModuleSections", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ButtonTextId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ModuleId")
                        .HasColumnType("int");

                    b.Property<string>("TextId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ButtonTextId");

                    b.HasIndex("ModuleId");

                    b.HasIndex("TextId");

                    b.ToTable("ModuleSections");
                });

            modelBuilder.Entity("diga.web.Models.Modules", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BigTitleTextId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool?>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("LongTextId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("PictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("SmallTitleTextId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BigTitleTextId");

                    b.HasIndex("LongTextId");

                    b.HasIndex("SmallTitleTextId");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("diga.web.Models.Questions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnswerTextId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FullAnswerTextId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("QuestionTextId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AnswerTextId");

                    b.HasIndex("FullAnswerTextId");

                    b.HasIndex("QuestionTextId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("diga.web.Models.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("diga.web.Models.Reviews", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameTextId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PositionTextId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ReviewTextId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("NameTextId");

                    b.HasIndex("PositionTextId");

                    b.HasIndex("ReviewTextId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("diga.web.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("diga.web.Models.Sectors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BigTitleTextId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("FullDescriptionTextId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LongTextId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SmallTitleTextId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FullDescriptionTextId");

                    b.ToTable("Sectors");
                });

            modelBuilder.Entity("diga.web.Models.TeamMembers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryTextId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DepartmentTextId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NameTextId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PositionTextId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProfileIcon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryTextId");

                    b.HasIndex("DepartmentTextId");

                    b.HasIndex("NameTextId");

                    b.HasIndex("PositionTextId");

                    b.ToTable("TeamMembers");
                });

            modelBuilder.Entity("diga.web.Models.Texts", b =>
                {
                    b.Property<string>("TextId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("En")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Es")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsHtml")
                        .HasColumnType("bit");

                    b.Property<string>("Pt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ru")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TextId");

                    b.ToTable("Texts");
                });

            modelBuilder.Entity("diga.web.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("diga.web.Models.Advantages", b =>
                {
                    b.HasOne("diga.web.Models.Texts", "LongText")
                        .WithMany()
                        .HasForeignKey("LongTextId");

                    b.HasOne("diga.web.Models.Texts", "ShortText")
                        .WithMany()
                        .HasForeignKey("ShortTextId");

                    b.HasOne("diga.web.Models.Texts", "TitleText")
                        .WithMany()
                        .HasForeignKey("TitleTextId");
                });

            modelBuilder.Entity("diga.web.Models.Articles", b =>
                {
                    b.HasOne("diga.web.Models.Texts", "Text")
                        .WithMany()
                        .HasForeignKey("TextId");

                    b.HasOne("diga.web.Models.Texts", "TitleText")
                        .WithMany()
                        .HasForeignKey("TitleTextId");
                });

            modelBuilder.Entity("diga.web.Models.Cases", b =>
                {
                    b.HasOne("diga.web.Models.Texts", "LongText")
                        .WithMany()
                        .HasForeignKey("LongTextId");

                    b.HasOne("diga.web.Models.Texts", "ShortText")
                        .WithMany()
                        .HasForeignKey("ShortTextId");

                    b.HasOne("diga.web.Models.Texts", "TitleText")
                        .WithMany()
                        .HasForeignKey("TitleTextId");
                });

            modelBuilder.Entity("diga.web.Models.Functions", b =>
                {
                    b.HasOne("diga.web.Models.Texts", "BigTitleText")
                        .WithMany()
                        .HasForeignKey("BigTitleTextId");

                    b.HasOne("diga.web.Models.Texts", "FullDescription")
                        .WithMany()
                        .HasForeignKey("FullDescriptionTextId");

                    b.HasOne("diga.web.Models.Texts", "LongText")
                        .WithMany()
                        .HasForeignKey("LongTextId");

                    b.HasOne("diga.web.Models.Modules", "Module")
                        .WithMany("Functions")
                        .HasForeignKey("ModuleId");

                    b.HasOne("diga.web.Models.Texts", "SmallTitleText")
                        .WithMany()
                        .HasForeignKey("SmallTitleTextId");
                });

            modelBuilder.Entity("diga.web.Models.ModuleSections", b =>
                {
                    b.HasOne("diga.web.Models.Texts", "ButtonText")
                        .WithMany()
                        .HasForeignKey("ButtonTextId");

                    b.HasOne("diga.web.Models.Modules", "Module")
                        .WithMany()
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("diga.web.Models.Texts", "Text")
                        .WithMany()
                        .HasForeignKey("TextId");
                });

            modelBuilder.Entity("diga.web.Models.Modules", b =>
                {
                    b.HasOne("diga.web.Models.Texts", "BigTitleText")
                        .WithMany()
                        .HasForeignKey("BigTitleTextId");

                    b.HasOne("diga.web.Models.Texts", "LongText")
                        .WithMany()
                        .HasForeignKey("LongTextId");

                    b.HasOne("diga.web.Models.Texts", "SmallTitleText")
                        .WithMany()
                        .HasForeignKey("SmallTitleTextId");
                });

            modelBuilder.Entity("diga.web.Models.Questions", b =>
                {
                    b.HasOne("diga.web.Models.Texts", "AnswerText")
                        .WithMany()
                        .HasForeignKey("AnswerTextId");

                    b.HasOne("diga.web.Models.Texts", "FullAnswerText")
                        .WithMany()
                        .HasForeignKey("FullAnswerTextId");

                    b.HasOne("diga.web.Models.Texts", "QuestionText")
                        .WithMany()
                        .HasForeignKey("QuestionTextId");
                });

            modelBuilder.Entity("diga.web.Models.Reviews", b =>
                {
                    b.HasOne("diga.web.Models.Texts", "NameText")
                        .WithMany()
                        .HasForeignKey("NameTextId");

                    b.HasOne("diga.web.Models.Texts", "PositionText")
                        .WithMany()
                        .HasForeignKey("PositionTextId");

                    b.HasOne("diga.web.Models.Texts", "ReviewText")
                        .WithMany()
                        .HasForeignKey("ReviewTextId");
                });

            modelBuilder.Entity("diga.web.Models.Sectors", b =>
                {
                    b.HasOne("diga.web.Models.Texts", "FullDescription")
                        .WithMany()
                        .HasForeignKey("FullDescriptionTextId");
                });

            modelBuilder.Entity("diga.web.Models.TeamMembers", b =>
                {
                    b.HasOne("diga.web.Models.Texts", "CountryText")
                        .WithMany()
                        .HasForeignKey("CountryTextId");

                    b.HasOne("diga.web.Models.Texts", "DepartmentText")
                        .WithMany()
                        .HasForeignKey("DepartmentTextId");

                    b.HasOne("diga.web.Models.Texts", "NameText")
                        .WithMany()
                        .HasForeignKey("NameTextId");

                    b.HasOne("diga.web.Models.Texts", "PositionText")
                        .WithMany()
                        .HasForeignKey("PositionTextId");
                });

            modelBuilder.Entity("diga.web.Models.User", b =>
                {
                    b.HasOne("diga.web.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId");
                });
#pragma warning restore 612, 618
        }
    }
}
