using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            modelBuilder.Entity<City>().HasIndex(c => c.cityName).IsUnique();
            modelBuilder.Entity<City>(c =>
            {
                c.Property(col => col.cityId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<District>().HasIndex(d => d.districtName).IsUnique();
            modelBuilder.Entity<District>(d =>
            {
                d.Property(col => col.districtId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<BloodBank>().HasIndex(bb => bb.bbName).IsUnique();
            modelBuilder.Entity<BloodBank>(bb =>
            {
                bb.Property(col => col.bbId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Blood>().HasIndex(b => b.bloodName).IsUnique();
            modelBuilder.Entity<Blood>(b =>
            {
                b.Property(col => col.bloodId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<BloodStock>(bs =>
            {
                bs.Property(col => col.bloodstockId).ValueGeneratedOnAdd();
            });
          

            modelBuilder.Entity<Donor>().HasIndex(c => c.email).IsUnique();
            modelBuilder.Entity<Donor>(c =>
            {
                c.Property(col => col.donorId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<RequestToBloodBank>(pr =>
            {
                pr.Property(col => col.rtbkId).ValueGeneratedOnAdd();
            });
           

            modelBuilder.Entity<RequestToDonor>(pr =>
            {
                pr.Property(col => col.rtdId).ValueGeneratedOnAdd();
            });
           

            modelBuilder.Entity<DonationRequest>(dr =>
            {
                dr.Property(col => col.drId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Account>(pr =>
            {
                pr.Property(col => col.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Message>(pr =>
            {
                pr.Property(col => col.mId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<MobiLinkRequest>(pr =>
            {
                pr.Property(col => col.mlrId).ValueGeneratedOnAdd();
            });


        }


        public DbSet<City> cities { get; set; }
        public DbSet<District> districts { get; set; }
        public DbSet<BloodBank> bloodBanks { get; set; }
        public DbSet<Donor> donors { get; set; }
        public DbSet<RequestToDonor> requestToDonors { get; set; }
        public DbSet<RequestToBloodBank> requestToBloodBanks { get; set; }
        public DbSet<DonationRequest> donorRequests { get; set; }
        public DbSet<Blood> bloods { get; set; }
        public DbSet<BloodStock> bloodStocks { get; set; }
        public DbSet<Account> accounts { get; set; }
        public DbSet<Message> messages { get; set; }
        public DbSet<MobiLinkRequest> mobiLinkRequests { get; set; }
      
    }
}
