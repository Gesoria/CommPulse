using CommPulse.DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace CommPulse.DAL
{
    public class MyDbContext : IdentityDbContext<ApplicationUser>
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
        public DbSet<Channel> Channels { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); //Базовый метод для конфигурации Identity

            //Конфигурация для сущности Channel
            modelBuilder.Entity<Channel>()
                .HasOne(e => e.Creator)
                .WithMany(e => e.UserChannels)
                .IsRequired();

            modelBuilder.Entity<Channel>()
                .HasMany(e => e.Members)
                .WithMany(e => e.MemberChannels);

            //Инорирование номера мобильного телефона  и двухфакторной аутентификации
            modelBuilder.Entity<ApplicationUser>().Ignore(u => u.PhoneNumber);
            modelBuilder.Entity<ApplicationUser>().Ignore(u => u.TwoFactorEnabled);
        }
    }

}

