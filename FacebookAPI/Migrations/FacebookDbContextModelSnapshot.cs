﻿// <auto-generated />
using System;
using FacebookAPI.App_Code.BOL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FacebookAPI.Migrations
{
    [DbContext(typeof(FacebookDbContext))]
    partial class FacebookDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CommentBody")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("DatePosted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DateUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("PictureId")
                        .HasColumnType("int");

                    b.Property<int?>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CommentId");

                    b.HasIndex("PictureId");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.Friend", b =>
                {
                    b.Property<int>("FriendId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateAccepted")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ReceiverId")
                        .HasColumnType("int");

                    b.Property<int>("SenderId")
                        .HasColumnType("int");

                    b.HasKey("FriendId");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderId");

                    b.ToTable("Friends");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.Gender", b =>
                {
                    b.Property<int>("GenderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("GenderName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProNouns")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("GenderId");

                    b.ToTable("Genders");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("GroupId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.GroupMessage", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DatePosted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.Property<int>("GroupUserId")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("MessageId");

                    b.HasIndex("GroupUserId");

                    b.ToTable("GroupMessages");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.GroupUser", b =>
                {
                    b.Property<int>("GroupUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdded")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("GroupUserId");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("GroupUsers");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.Interest", b =>
                {
                    b.Property<int>("InterestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("InterestName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("InterestId");

                    b.HasIndex("ProfileId");

                    b.HasIndex("UserId");

                    b.ToTable("Interests");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.IssueTask", b =>
                {
                    b.Property<int>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("TaskName")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("varchar(400)");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("TaskId");

                    b.HasIndex("TypeId");

                    b.HasIndex("UserId");

                    b.ToTable("IssueTasks");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.IssueTaskType", b =>
                {
                    b.Property<int>("TypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("TypeId");

                    b.ToTable("IssueTaskTypes");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.Job", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("JobDescription")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("JobId");

                    b.HasIndex("LocationId");

                    b.HasIndex("ProfileId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.Like", b =>
                {
                    b.Property<long>("LikeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int?>("CommentId")
                        .HasColumnType("int");

                    b.Property<int?>("PictureId")
                        .HasColumnType("int");

                    b.Property<int?>("PostId")
                        .HasColumnType("int");

                    b.Property<int?>("ReplyId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LikeId");

                    b.HasIndex("CommentId");

                    b.HasIndex("PictureId");

                    b.HasIndex("PostId");

                    b.HasIndex("ReplyId");

                    b.HasIndex("UserId");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LocationId");

                    b.HasIndex("UserId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.Picture", b =>
                {
                    b.Property<int>("PictureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CaptionText")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("PictureFileName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<bool>("ProfilePicture")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("PictureId");

                    b.HasIndex("UserId");

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DatePosted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DateUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("PostBody")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.Profile", b =>
                {
                    b.Property<int>("ProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AboutMe")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("ProfileId");

                    b.HasIndex("GenderId");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.Reply", b =>
                {
                    b.Property<int>("ReplyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CommentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatePosted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DateUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ReplyBody")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ReplyId");

                    b.HasIndex("CommentId");

                    b.HasIndex("UserId");

                    b.ToTable("Replies");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("IsAdmin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("ProfileId")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.Comment", b =>
                {
                    b.HasOne("FacebookAPI.App_Code.BOL.Picture", "Picture")
                        .WithMany("Comments")
                        .HasForeignKey("PictureId");

                    b.HasOne("FacebookAPI.App_Code.BOL.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId");

                    b.HasOne("FacebookAPI.App_Code.BOL.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Picture");

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.Friend", b =>
                {
                    b.HasOne("FacebookAPI.App_Code.BOL.User", "Receiver")
                        .WithMany()
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FacebookAPI.App_Code.BOL.User", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Receiver");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.GroupMessage", b =>
                {
                    b.HasOne("FacebookAPI.App_Code.BOL.GroupUser", "GroupUser")
                        .WithMany("Messages")
                        .HasForeignKey("GroupUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GroupUser");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.GroupUser", b =>
                {
                    b.HasOne("FacebookAPI.App_Code.BOL.Group", "Group")
                        .WithMany("GroupUsers")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FacebookAPI.App_Code.BOL.User", "User")
                        .WithMany("GroupUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.Interest", b =>
                {
                    b.HasOne("FacebookAPI.App_Code.BOL.Profile", "Profile")
                        .WithMany("Interests")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FacebookAPI.App_Code.BOL.User", "User")
                        .WithMany("Interests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.IssueTask", b =>
                {
                    b.HasOne("FacebookAPI.App_Code.BOL.IssueTaskType", "Type")
                        .WithMany("IssueTasks")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FacebookAPI.App_Code.BOL.User", "User")
                        .WithMany("IssueTasks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Type");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.Job", b =>
                {
                    b.HasOne("FacebookAPI.App_Code.BOL.Location", "Location")
                        .WithMany("Jobs")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FacebookAPI.App_Code.BOL.Profile", "Profile")
                        .WithMany("Jobs")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.Like", b =>
                {
                    b.HasOne("FacebookAPI.App_Code.BOL.Comment", "Comment")
                        .WithMany("Likes")
                        .HasForeignKey("CommentId");

                    b.HasOne("FacebookAPI.App_Code.BOL.Picture", "Picture")
                        .WithMany("Likes")
                        .HasForeignKey("PictureId");

                    b.HasOne("FacebookAPI.App_Code.BOL.Post", "Post")
                        .WithMany("Likes")
                        .HasForeignKey("PostId");

                    b.HasOne("FacebookAPI.App_Code.BOL.Reply", "Reply")
                        .WithMany("Likes")
                        .HasForeignKey("ReplyId");

                    b.HasOne("FacebookAPI.App_Code.BOL.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comment");

                    b.Navigation("Picture");

                    b.Navigation("Post");

                    b.Navigation("Reply");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.Location", b =>
                {
                    b.HasOne("FacebookAPI.App_Code.BOL.User", "User")
                        .WithMany("Locations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.Picture", b =>
                {
                    b.HasOne("FacebookAPI.App_Code.BOL.User", "User")
                        .WithMany("Pictures")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.Post", b =>
                {
                    b.HasOne("FacebookAPI.App_Code.BOL.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.Profile", b =>
                {
                    b.HasOne("FacebookAPI.App_Code.BOL.Gender", "Gender")
                        .WithMany("Profiles")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gender");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.Reply", b =>
                {
                    b.HasOne("FacebookAPI.App_Code.BOL.Comment", "Comment")
                        .WithMany("Replies")
                        .HasForeignKey("CommentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FacebookAPI.App_Code.BOL.User", "User")
                        .WithMany("Replies")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.User", b =>
                {
                    b.HasOne("FacebookAPI.App_Code.BOL.Profile", "Profile")
                        .WithOne("User")
                        .HasForeignKey("FacebookAPI.App_Code.BOL.User", "ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.Comment", b =>
                {
                    b.Navigation("Likes");

                    b.Navigation("Replies");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.Gender", b =>
                {
                    b.Navigation("Profiles");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.Group", b =>
                {
                    b.Navigation("GroupUsers");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.GroupUser", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.IssueTaskType", b =>
                {
                    b.Navigation("IssueTasks");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.Location", b =>
                {
                    b.Navigation("Jobs");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.Picture", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Likes");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.Post", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Likes");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.Profile", b =>
                {
                    b.Navigation("Interests");

                    b.Navigation("Jobs");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.Reply", b =>
                {
                    b.Navigation("Likes");
                });

            modelBuilder.Entity("FacebookAPI.App_Code.BOL.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("GroupUsers");

                    b.Navigation("Interests");

                    b.Navigation("IssueTasks");

                    b.Navigation("Locations");

                    b.Navigation("Pictures");

                    b.Navigation("Posts");

                    b.Navigation("Replies");
                });
#pragma warning restore 612, 618
        }
    }
}
