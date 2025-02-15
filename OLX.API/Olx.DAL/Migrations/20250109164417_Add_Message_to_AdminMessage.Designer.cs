﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Olx.DAL.Data;

#nullable disable

namespace Olx.DAL.Migrations
{
    [DbContext(typeof(OlxDbContext))]
    [Migration("20250109164417_Add_Message_to_AdminMessage")]
    partial class Add_Message_to_AdminMessage
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AdvertFilterValue", b =>
                {
                    b.Property<int>("AdvertsId")
                        .HasColumnType("integer");

                    b.Property<int>("FilterValuesId")
                        .HasColumnType("integer");

                    b.HasKey("AdvertsId", "FilterValuesId");

                    b.HasIndex("FilterValuesId");

                    b.ToTable("tbl_AdvertFilterValues", (string)null);
                });

            modelBuilder.Entity("AdvertOlxUser", b =>
                {
                    b.Property<int>("FavoriteAdvertsId")
                        .HasColumnType("integer");

                    b.Property<int>("FavoritedByUsersId")
                        .HasColumnType("integer");

                    b.HasKey("FavoriteAdvertsId", "FavoritedByUsersId");

                    b.HasIndex("FavoritedByUsersId");

                    b.ToTable("tbl_UserFavorites", (string)null);
                });

            modelBuilder.Entity("CategoryFilter", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("integer");

                    b.Property<int>("FiltersId")
                        .HasColumnType("integer");

                    b.HasKey("CategoriesId", "FiltersId");

                    b.HasIndex("FiltersId");

                    b.ToTable("tbl_CategoryFilters", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Olx.BLL.Entities.AdminMessages.AdminMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<int>("MessageId")
                        .HasColumnType("integer");

                    b.Property<bool>("Readed")
                        .HasColumnType("boolean");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("MessageId");

                    b.HasIndex("UserId");

                    b.ToTable("tbl_AdminMessages");
                });

            modelBuilder.Entity("Olx.BLL.Entities.AdminMessages.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("character varying(2000)");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.ToTable("tbl_Messages");
                });

            modelBuilder.Entity("Olx.BLL.Entities.Advert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Approved")
                        .HasColumnType("boolean");

                    b.Property<bool>("Blocked")
                        .HasColumnType("boolean");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasMaxLength(128)
                        .IsUnicode(false)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ContactPersone")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("character varying(5000)");

                    b.Property<bool>("IsContractPrice")
                        .HasColumnType("boolean");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("character varying(13)");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("SettlementRef")
                        .IsRequired()
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("character varying(36)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SettlementRef");

                    b.HasIndex("UserId");

                    b.ToTable("tbl_Adverts");
                });

            modelBuilder.Entity("Olx.BLL.Entities.AdvertImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("AdvertId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("Priority")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AdvertId");

                    b.ToTable("tbl_AdvertImages");
                });

            modelBuilder.Entity("Olx.BLL.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Image")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("tbl_Categories");
                });

            modelBuilder.Entity("Olx.BLL.Entities.ChatEntities.Chat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AdvertId")
                        .HasColumnType("integer");

                    b.Property<int>("BuyerId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeletedForBuyer")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeletedForSeller")
                        .HasColumnType("boolean");

                    b.Property<int>("SellerId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AdvertId");

                    b.HasIndex("BuyerId");

                    b.HasIndex("SellerId");

                    b.ToTable("tbl_Chats");
                });

            modelBuilder.Entity("Olx.BLL.Entities.ChatEntities.ChatMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ChatId")
                        .HasColumnType("integer");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("character varying(2000)");

                    b.Property<bool>("Readed")
                        .HasColumnType("boolean");

                    b.Property<int>("SenderId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.HasIndex("SenderId");

                    b.ToTable("tbl_ChatMessages");
                });

            modelBuilder.Entity("Olx.BLL.Entities.FilterEntities.Filter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("tbl_Filters");
                });

            modelBuilder.Entity("Olx.BLL.Entities.FilterEntities.FilterValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("FilterId")
                        .HasColumnType("integer");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.HasIndex("FilterId");

                    b.ToTable("tbl_FilterValues");
                });

            modelBuilder.Entity("Olx.BLL.Entities.NewPost.Area", b =>
                {
                    b.Property<string>("Ref")
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("character varying(36)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("RegionType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Ref");

                    b.ToTable("tbl_Areas");
                });

            modelBuilder.Entity("Olx.BLL.Entities.NewPost.Region", b =>
                {
                    b.Property<string>("Ref")
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("character varying(36)");

                    b.Property<string>("AreaRef")
                        .IsRequired()
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("character varying(36)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("RegionType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Ref");

                    b.HasIndex("AreaRef");

                    b.ToTable("tbl_Regions");
                });

            modelBuilder.Entity("Olx.BLL.Entities.NewPost.Settlement", b =>
                {
                    b.Property<string>("Ref")
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("character varying(36)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Region")
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("character varying(36)");

                    b.Property<string>("SettlementTypeDescription")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Ref");

                    b.HasIndex("Region");

                    b.ToTable("tbl_Settlements");
                });

            modelBuilder.Entity("Olx.BLL.Entities.NewPost.Warehous", b =>
                {
                    b.Property<string>("Ref")
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("character varying(36)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SettlementRef")
                        .IsRequired()
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("character varying(36)");

                    b.HasKey("Ref");

                    b.HasIndex("SettlementRef");

                    b.ToTable("tbl_Warehouses");
                });

            modelBuilder.Entity("Olx.BLL.Entities.OlxUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("About")
                        .HasMaxLength(4000)
                        .HasColumnType("character varying(4000)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime>("LastActivity")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("LastName")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("Photo")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<string>("SettlementRef")
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("character varying(36)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("WebSite")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.HasIndex("SettlementRef");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Olx.BLL.Entities.RefreshToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("OlxUserId")
                        .HasColumnType("integer");

                    b.Property<string>("Token")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("OlxUserId");

                    b.ToTable("tbl_RefreshTokens");
                });

            modelBuilder.Entity("AdvertFilterValue", b =>
                {
                    b.HasOne("Olx.BLL.Entities.Advert", null)
                        .WithMany()
                        .HasForeignKey("AdvertsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Olx.BLL.Entities.FilterEntities.FilterValue", null)
                        .WithMany()
                        .HasForeignKey("FilterValuesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AdvertOlxUser", b =>
                {
                    b.HasOne("Olx.BLL.Entities.Advert", null)
                        .WithMany()
                        .HasForeignKey("FavoriteAdvertsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Olx.BLL.Entities.OlxUser", null)
                        .WithMany()
                        .HasForeignKey("FavoritedByUsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CategoryFilter", b =>
                {
                    b.HasOne("Olx.BLL.Entities.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Olx.BLL.Entities.FilterEntities.Filter", null)
                        .WithMany()
                        .HasForeignKey("FiltersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Olx.BLL.Entities.OlxUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Olx.BLL.Entities.OlxUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Olx.BLL.Entities.OlxUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Olx.BLL.Entities.OlxUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Olx.BLL.Entities.AdminMessages.AdminMessage", b =>
                {
                    b.HasOne("Olx.BLL.Entities.AdminMessages.Message", "Message")
                        .WithMany("AdminMessages")
                        .HasForeignKey("MessageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Olx.BLL.Entities.OlxUser", "User")
                        .WithMany("AdminMessages")
                        .HasForeignKey("UserId");

                    b.Navigation("Message");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Olx.BLL.Entities.Advert", b =>
                {
                    b.HasOne("Olx.BLL.Entities.Category", "Category")
                        .WithMany("Adverts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Olx.BLL.Entities.NewPost.Settlement", "Settlement")
                        .WithMany("Adverts")
                        .HasForeignKey("SettlementRef")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Olx.BLL.Entities.OlxUser", "User")
                        .WithMany("Adverts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Settlement");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Olx.BLL.Entities.AdvertImage", b =>
                {
                    b.HasOne("Olx.BLL.Entities.Advert", "Advert")
                        .WithMany("Images")
                        .HasForeignKey("AdvertId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Advert");
                });

            modelBuilder.Entity("Olx.BLL.Entities.Category", b =>
                {
                    b.HasOne("Olx.BLL.Entities.Category", "Parent")
                        .WithMany("Childs")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("Olx.BLL.Entities.ChatEntities.Chat", b =>
                {
                    b.HasOne("Olx.BLL.Entities.Advert", "Advert")
                        .WithMany("Chats")
                        .HasForeignKey("AdvertId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Olx.BLL.Entities.OlxUser", "Buyer")
                        .WithMany("SellChats")
                        .HasForeignKey("BuyerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Olx.BLL.Entities.OlxUser", "Seller")
                        .WithMany("BuyChats")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Advert");

                    b.Navigation("Buyer");

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("Olx.BLL.Entities.ChatEntities.ChatMessage", b =>
                {
                    b.HasOne("Olx.BLL.Entities.ChatEntities.Chat", "Chat")
                        .WithMany("Messages")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Olx.BLL.Entities.OlxUser", "Sender")
                        .WithMany("ChatMessages")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chat");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("Olx.BLL.Entities.FilterEntities.FilterValue", b =>
                {
                    b.HasOne("Olx.BLL.Entities.FilterEntities.Filter", "Filter")
                        .WithMany("Values")
                        .HasForeignKey("FilterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Filter");
                });

            modelBuilder.Entity("Olx.BLL.Entities.NewPost.Region", b =>
                {
                    b.HasOne("Olx.BLL.Entities.NewPost.Area", "Area")
                        .WithMany("Regions")
                        .HasForeignKey("AreaRef")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Area");
                });

            modelBuilder.Entity("Olx.BLL.Entities.NewPost.Settlement", b =>
                {
                    b.HasOne("Olx.BLL.Entities.NewPost.Region", "SettlementRegion")
                        .WithMany("Settlements")
                        .HasForeignKey("Region")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("SettlementRegion");
                });

            modelBuilder.Entity("Olx.BLL.Entities.NewPost.Warehous", b =>
                {
                    b.HasOne("Olx.BLL.Entities.NewPost.Settlement", "Settlement")
                        .WithMany("Warehous")
                        .HasForeignKey("SettlementRef")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Settlement");
                });

            modelBuilder.Entity("Olx.BLL.Entities.OlxUser", b =>
                {
                    b.HasOne("Olx.BLL.Entities.NewPost.Settlement", "Settlement")
                        .WithMany("Users")
                        .HasForeignKey("SettlementRef");

                    b.Navigation("Settlement");
                });

            modelBuilder.Entity("Olx.BLL.Entities.RefreshToken", b =>
                {
                    b.HasOne("Olx.BLL.Entities.OlxUser", "OlxUser")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("OlxUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OlxUser");
                });

            modelBuilder.Entity("Olx.BLL.Entities.AdminMessages.Message", b =>
                {
                    b.Navigation("AdminMessages");
                });

            modelBuilder.Entity("Olx.BLL.Entities.Advert", b =>
                {
                    b.Navigation("Chats");

                    b.Navigation("Images");
                });

            modelBuilder.Entity("Olx.BLL.Entities.Category", b =>
                {
                    b.Navigation("Adverts");

                    b.Navigation("Childs");
                });

            modelBuilder.Entity("Olx.BLL.Entities.ChatEntities.Chat", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("Olx.BLL.Entities.FilterEntities.Filter", b =>
                {
                    b.Navigation("Values");
                });

            modelBuilder.Entity("Olx.BLL.Entities.NewPost.Area", b =>
                {
                    b.Navigation("Regions");
                });

            modelBuilder.Entity("Olx.BLL.Entities.NewPost.Region", b =>
                {
                    b.Navigation("Settlements");
                });

            modelBuilder.Entity("Olx.BLL.Entities.NewPost.Settlement", b =>
                {
                    b.Navigation("Adverts");

                    b.Navigation("Users");

                    b.Navigation("Warehous");
                });

            modelBuilder.Entity("Olx.BLL.Entities.OlxUser", b =>
                {
                    b.Navigation("AdminMessages");

                    b.Navigation("Adverts");

                    b.Navigation("BuyChats");

                    b.Navigation("ChatMessages");

                    b.Navigation("RefreshTokens");

                    b.Navigation("SellChats");
                });
#pragma warning restore 612, 618
        }
    }
}
