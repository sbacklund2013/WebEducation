using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebEducation.Models;

namespace WebEducation.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<ForumPost> ForumPosts { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<InterestProfile> InterestProfiles { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Author>().HasNoKey();
            //modelBuilder.Entity<InterestProfile>().HasNoKey();
            //modelBuilder.Entity<Subscriber>().HasNoKey();
            //modelBuilder.Entity<Vote>().HasNoKey();
            //modelBuilder.Entity<IdentityUserLogin>().HasNoKey();

            modelBuilder.Entity<Author>()
                .HasKey(bc => new { bc.ProfileId, bc.ClassId });                
            modelBuilder.Entity<Author>()
                .HasOne(bc => bc.Profile)
                .WithMany(b => b.AuthoredClasses)
                .HasForeignKey(bc => bc.ProfileId);
            modelBuilder.Entity<Author>()
                .HasOne(bc => bc.Class)
                .WithMany(c => c.Authors)
                .HasForeignKey(bc => bc.ProfileId);

            modelBuilder.Entity<InterestProfile>()
               .HasKey(bc => new { bc.InterestId, bc.ProfileId });
            modelBuilder.Entity<InterestProfile>()
                .HasOne(bc => bc.Interest)
                .WithMany(b => b.InterestProfiles)
                .HasForeignKey(bc => bc.InterestId);
            modelBuilder.Entity<InterestProfile>()
                .HasOne(bc => bc.Profile)
                .WithMany(c => c.Interests)
                .HasForeignKey(bc => bc.InterestId);

            modelBuilder.Entity<Subscriber>()
                   .HasKey(bc => new { bc.ProfileId, bc.ClassId });
            modelBuilder.Entity<Subscriber>()
                .HasOne(bc => bc.Profile)
                .WithMany(b => b.SubscribedClasses)
                .HasForeignKey(bc => bc.ProfileId);
            modelBuilder.Entity<Subscriber>()
                .HasOne(bc => bc.Class)
                .WithMany(c => c.Subscribers)
                .HasForeignKey(bc => bc.ProfileId);

            modelBuilder.Entity<Vote>()
                .HasKey(bc => new { bc.PostId, bc.ProfileId });
            modelBuilder.Entity<Vote>()
                .HasOne(bc => bc.Post)
                .WithMany(b => b.Votes)
                .HasForeignKey(bc => bc.PostId);
            modelBuilder.Entity<Vote>()
                .HasOne(bc => bc.Profile)
                .WithMany(c => c.Votes)
                .HasForeignKey(bc => bc.ProfileId);
        }
    }
}
