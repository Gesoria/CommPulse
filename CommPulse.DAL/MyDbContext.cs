using CommPulse.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace CommPulse.DAL
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Channel> Channels { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Channel>()
                .HasOne(e => e.Creator)
                .WithMany(e => e.UserChannels)
                .IsRequired();

            modelBuilder.Entity<Channel>()
                .HasMany(e => e.Members)
                .WithMany(e => e.MemberChannels);
        }
    }

}

