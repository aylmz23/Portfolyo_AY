using Microsoft.EntityFrameworkCore;
using Portfolyo_AY.Entities;

namespace Portfolyo_AY.Data
{
    public class MsSqlContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=AYHOME;database=Portfolio_Db;Trusted_Connection=True;");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<About>().Property(x=>x.Graduation).HasMaxLength(50);
        //}

        public DbSet<About> Abouts { get; set; }
        public DbSet<Fact> Facts { get; set; }
        public DbSet<Reference> References { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ContactForm> ContactForms { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRolse { get; set; }

    }
}
