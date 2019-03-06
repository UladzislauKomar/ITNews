using ITNews.Data.Contracts.Entities;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITNews.Data.Implementation.Context
{
    public class ITNewsDbContext : IdentityDbContext<UserEntity>
    {
        public ITNewsDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<CommentEntity> Comments { get; set; }
        public DbSet<CommentLikeEntity> CommentLikes { get; set; }
        public DbSet<NewsEntity> News { get; set; }
        public DbSet<NewsRatingEntity> NewsRatings { get; set; }
        public DbSet<SectionEntity> Sections { get; set; }
        public DbSet<TagEntity> Tags { get; set; }
        public DbSet<NewsTagEntity> NewsTags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>()
                .HasMany(x => x.Comments)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<UserEntity>()
                .HasMany(x => x.Likes)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<UserEntity>()
                .HasMany(x => x.News)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<UserEntity>()
                .HasMany(x => x.Ratings)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<NewsEntity>()
                .HasMany(x => x.Comments)
                .WithOne(x => x.News)
                .HasForeignKey(x => x.NewsId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CommentEntity>()
                .HasMany(x => x.Likes)
                .WithOne(x => x.Comment)
                .HasForeignKey(x => x.CommentId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<NewsEntity>()
                .HasMany(x => x.Ratings)
                .WithOne(x => x.News)
                .HasForeignKey(x => x.NewsId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<NewsTagEntity>()
                .HasKey(nt => new { nt.NewsId, nt.TagId });
            
            modelBuilder.Entity<NewsTagEntity>()
                .HasOne(x => x.Tag)
                .WithMany(x => x.News)
                .HasForeignKey(x => x.TagId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<NewsTagEntity>()
                .HasOne(x => x.News)
                .WithMany(x => x.Tags)
                .HasForeignKey(x => x.NewsId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<SectionEntity>()
                .HasMany(x => x.News)
                .WithOne(x => x.Section)
                .HasForeignKey(x => x.SectionId)
                .OnDelete(DeleteBehavior.SetNull);

            base.OnModelCreating(modelBuilder);
        }
    }
}
