using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RssPresentor.Model.Entities;
namespace RssPresentor.Data
{
    public class RssPresentorContext:DbContext
    {
        public DbSet<RssFeed> RssFeeds { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<ArticleCategory> ArticlesCategories { get; set; }

        public RssPresentorContext(DbContextOptions<RssPresentorContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Cascade;
            }


            //ArticleCategory
            modelBuilder.Entity<ArticleCategory>()
                .HasKey(t => new { t.ArticleId, t.CategoryId });

            modelBuilder.Entity<ArticleCategory>()
                .HasOne(pt => pt.Article)
                .WithMany(p => p.ArticlesCategories)
                .HasForeignKey(pt => pt.ArticleId);

            modelBuilder.Entity<ArticleCategory>()
                .HasOne(pt => pt.Category)
                .WithMany(p => p.ArticlesCategories)
                .HasForeignKey(pt => pt.CategoryId);
        }
    }
}
