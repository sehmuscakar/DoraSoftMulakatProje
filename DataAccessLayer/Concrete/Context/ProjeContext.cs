using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete.Context
{
    public class ProjeContext : IdentityDbContext<AppUser, AppRole,int>
    {
        public DbSet<Head> Heads { get; set; }
        public DbSet<Poll> Polls { get; set; }
        public DbSet<PollCategory> PollCategories { get; set; }
        public DbSet<PollReport> PollReports { get; set; }
        public DbSet<PollUser> PollUsers { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<ContactCompany> ContactCompanies { get; set; }
        public DbSet<PostContact> PostContacts { get; set; }




        //public ProjeContext(DbContextOptions<ProjeContext> options) : base(options) dal da sıkıntı çıkardığı  için constractır diğer db yolu yönetimini kullandım
        //{

        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)// overide on yaz gelir
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-PBFD0LU;  database=PollDb; integrated security=true; TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder builder) // fluent api ile ilişkilerimiz yapılandırdık.
        {
            builder.Entity<Head>(entity =>
            {

                entity.HasOne(x => x.AppUser).WithMany(x => x.Heads).HasForeignKey(x => x.AppUserId);
            });

            builder.Entity<Poll>(entity =>
            {
                entity.HasOne(x => x.AppUser).WithMany(x => x.Polls).HasForeignKey(x => x.AppUserId);
                entity.HasOne(x => x.PollCategory).WithMany(x => x.Polls).HasForeignKey(x => x.PollCategoryId);
                entity.HasOne(x => x.PollReport).WithMany(x => x.Polls).HasForeignKey(x => x.PollReportId);
            });

            builder.Entity<PollUser>(entity =>
            {
                entity.HasOne(x => x.Poll).WithMany(x => x.PollUsers).HasForeignKey(x => x.PollId);
            });


            builder.Entity<PollCategory>(entity =>
            {

                entity.HasOne(x => x.AppUser).WithMany(x => x.pollCategories).HasForeignKey(x => x.AppUserId);
            });

            builder.Entity<PollReport>(entity =>
            {

                entity.HasOne(x => x.AppUser).WithMany(x => x.pollReports).HasForeignKey(x => x.AppUserId);
            });

            builder.Entity<About>(entity =>
            {

                entity.HasOne(x => x.AppUser).WithMany(x => x.Abouts).HasForeignKey(x => x.AppUserId);
            });

            builder.Entity<Service>(entity =>
            {

                entity.HasOne(x => x.AppUser).WithMany(x => x.Services).HasForeignKey(x => x.AppUserId);
            });

            builder.Entity<Team>(entity =>
            {

                entity.HasOne(x => x.AppUser).WithMany(x => x.Teams).HasForeignKey(x => x.AppUserId);
            });

            builder.Entity<Testimonial>(entity =>
            {

                entity.HasOne(x => x.AppUser).WithMany(x => x.Testimonials).HasForeignKey(x => x.AppUserId);
            });

            builder.Entity<ContactCompany>(entity =>
            {

                entity.HasOne(x => x.AppUser).WithMany(x => x.ContactCompanies).HasForeignKey(x => x.AppUserId);
            });

            base.OnModelCreating(builder);
        }

    }
}
