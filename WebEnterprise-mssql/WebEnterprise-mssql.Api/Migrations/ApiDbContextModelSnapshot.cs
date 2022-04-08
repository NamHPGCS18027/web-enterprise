﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebEnterprise_mssql.Api.Data;

namespace WebEnterprise_mssql.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    partial class ApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("CategoriesPosts", b =>
                {
                    b.Property<Guid>("categoriesCategoryId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("postsPostId")
                        .HasColumnType("TEXT");

                    b.HasKey("categoriesCategoryId", "postsPostId");

                    b.HasIndex("postsPostId");

                    b.ToTable("CategoriesPosts");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("WebEnterprise_mssql.Api.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DOB")
                        .HasColumnType("TEXT");

                    b.Property<string>("DepartmentId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("DepartmentsDepartmentId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("RoleNameRoleId")
                        .HasColumnType("TEXT");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<int>("StaffId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentsDepartmentId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.HasIndex("RoleNameRoleId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("WebEnterprise_mssql.Api.Models.Categories", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("WebEnterprise_mssql.Api.Models.Comments", b =>
                {
                    b.Property<Guid>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsChild")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("LastModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ParentId")
                        .HasColumnType("TEXT");

                    b.Property<string>("PostId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("PostsPostId")
                        .HasColumnType("TEXT");

                    b.Property<string>("userId")
                        .HasColumnType("TEXT");

                    b.HasKey("CommentId");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("PostsPostId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("WebEnterprise_mssql.Api.Models.Departments", b =>
                {
                    b.Property<Guid>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("DepartmentName")
                        .HasColumnType("TEXT");

                    b.HasKey("DepartmentId");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("WebEnterprise_mssql.Api.Models.FilesPath", b =>
                {
                    b.Property<Guid>("FilesPathID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("PostId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("PostsPostId")
                        .HasColumnType("TEXT");

                    b.Property<string>("filePath")
                        .HasColumnType("TEXT");

                    b.HasKey("FilesPathID");

                    b.HasIndex("PostsPostId");

                    b.ToTable("FilesPath");
                });

            modelBuilder.Entity("WebEnterprise_mssql.Api.Models.Posts", b =>
                {
                    b.Property<Guid>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Desc")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsAssigned")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("LastModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("QACUserId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("SubmissionsId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("TopicId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("TopicsTopicId")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("content")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("createdDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("feedback")
                        .HasColumnType("TEXT");

                    b.Property<bool>("isAnonymous")
                        .HasColumnType("INTEGER");

                    b.Property<string>("title")
                        .HasColumnType("TEXT");

                    b.Property<string>("username")
                        .HasColumnType("TEXT");

                    b.HasKey("PostId");

                    b.HasIndex("SubmissionsId");

                    b.HasIndex("TopicsTopicId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("WebEnterprise_mssql.Api.Models.RefreshToken", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsRevoked")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsUsed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("JwtId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Token")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("UserId");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("WebEnterprise_mssql.Api.Models.Roles", b =>
                {
                    b.Property<Guid>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleName")
                        .HasColumnType("TEXT");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("WebEnterprise_mssql.Api.Models.Submissions", b =>
                {
                    b.Property<Guid>("SubmissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ClosureDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("DescriptionSubmission")
                        .HasColumnType("TEXT");

                    b.Property<string>("FinalClosureDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("SubmissionName")
                        .HasColumnType("TEXT");

                    b.HasKey("SubmissionId");

                    b.ToTable("Submissions");
                });

            modelBuilder.Entity("WebEnterprise_mssql.Api.Models.Topics", b =>
                {
                    b.Property<Guid>("TopicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("ClosureDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("FinalClosureDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("TopicName")
                        .HasColumnType("TEXT");

                    b.HasKey("TopicId");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("WebEnterprise_mssql.Api.Models.Views", b =>
                {
                    b.Property<Guid>("ViewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("LastVistedDate")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("PostsPostId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("postId")
                        .HasColumnType("TEXT");

                    b.Property<string>("userId")
                        .HasColumnType("TEXT");

                    b.HasKey("ViewId");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("PostsPostId");

                    b.ToTable("Views");
                });

            modelBuilder.Entity("WebEnterprise_mssql.Api.Models.Votes", b =>
                {
                    b.Property<Guid>("voteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("PostsPostId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("postId")
                        .HasColumnType("TEXT");

                    b.Property<string>("userDownVote")
                        .HasColumnType("TEXT");

                    b.Property<string>("userUpvote")
                        .HasColumnType("TEXT");

                    b.HasKey("voteId");

                    b.HasIndex("PostsPostId");

                    b.ToTable("Votes");
                });

            modelBuilder.Entity("CategoriesPosts", b =>
                {
                    b.HasOne("WebEnterprise_mssql.Api.Models.Categories", null)
                        .WithMany()
                        .HasForeignKey("categoriesCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebEnterprise_mssql.Api.Models.Posts", null)
                        .WithMany()
                        .HasForeignKey("postsPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("WebEnterprise_mssql.Api.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("WebEnterprise_mssql.Api.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebEnterprise_mssql.Api.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("WebEnterprise_mssql.Api.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebEnterprise_mssql.Api.Models.ApplicationUser", b =>
                {
                    b.HasOne("WebEnterprise_mssql.Api.Models.Departments", "Departments")
                        .WithMany("ApplicationUser")
                        .HasForeignKey("DepartmentsDepartmentId");

                    b.HasOne("WebEnterprise_mssql.Api.Models.Roles", "RoleName")
                        .WithMany("ApplicationUser")
                        .HasForeignKey("RoleNameRoleId");

                    b.Navigation("Departments");

                    b.Navigation("RoleName");
                });

            modelBuilder.Entity("WebEnterprise_mssql.Api.Models.Comments", b =>
                {
                    b.HasOne("WebEnterprise_mssql.Api.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("Comments")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("WebEnterprise_mssql.Api.Models.Posts", "Posts")
                        .WithMany("Comments")
                        .HasForeignKey("PostsPostId");

                    b.Navigation("ApplicationUser");

                    b.Navigation("Posts");
                });

            modelBuilder.Entity("WebEnterprise_mssql.Api.Models.FilesPath", b =>
                {
                    b.HasOne("WebEnterprise_mssql.Api.Models.Posts", "Posts")
                        .WithMany("filesPaths")
                        .HasForeignKey("PostsPostId");

                    b.Navigation("Posts");
                });

            modelBuilder.Entity("WebEnterprise_mssql.Api.Models.Posts", b =>
                {
                    b.HasOne("WebEnterprise_mssql.Api.Models.Submissions", "Submissions")
                        .WithMany("Posts")
                        .HasForeignKey("SubmissionsId");

                    b.HasOne("WebEnterprise_mssql.Api.Models.Topics", "Topics")
                        .WithMany("posts")
                        .HasForeignKey("TopicsTopicId");

                    b.HasOne("WebEnterprise_mssql.Api.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("Posts")
                        .HasForeignKey("UserId");

                    b.Navigation("ApplicationUser");

                    b.Navigation("Submissions");

                    b.Navigation("Topics");
                });

            modelBuilder.Entity("WebEnterprise_mssql.Api.Models.RefreshToken", b =>
                {
                    b.HasOne("WebEnterprise_mssql.Api.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebEnterprise_mssql.Api.Models.Views", b =>
                {
                    b.HasOne("WebEnterprise_mssql.Api.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("Views")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("WebEnterprise_mssql.Api.Models.Posts", "Posts")
                        .WithMany("Views")
                        .HasForeignKey("PostsPostId");

                    b.Navigation("ApplicationUser");

                    b.Navigation("Posts");
                });

            modelBuilder.Entity("WebEnterprise_mssql.Api.Models.Votes", b =>
                {
                    b.HasOne("WebEnterprise_mssql.Api.Models.Posts", "Posts")
                        .WithMany()
                        .HasForeignKey("PostsPostId");

                    b.Navigation("Posts");
                });

            modelBuilder.Entity("WebEnterprise_mssql.Api.Models.ApplicationUser", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Posts");

                    b.Navigation("Views");
                });

            modelBuilder.Entity("WebEnterprise_mssql.Api.Models.Departments", b =>
                {
                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("WebEnterprise_mssql.Api.Models.Posts", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("filesPaths");

                    b.Navigation("Views");
                });

            modelBuilder.Entity("WebEnterprise_mssql.Api.Models.Roles", b =>
                {
                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("WebEnterprise_mssql.Api.Models.Submissions", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("WebEnterprise_mssql.Api.Models.Topics", b =>
                {
                    b.Navigation("posts");
                });
#pragma warning restore 612, 618
        }
    }
}
