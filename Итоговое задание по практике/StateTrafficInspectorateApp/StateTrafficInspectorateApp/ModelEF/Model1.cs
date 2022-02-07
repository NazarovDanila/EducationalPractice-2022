using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace StateTrafficInspectorateApp.ModelEF
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=ModelSTI")
        {
        }

        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<CarManufacturer> CarManufacturer { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Driver> Driver { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<License> License { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TypeOfDrive> TypeOfDrive { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarManufacturer>()
                .HasMany(e => e.Car)
                .WithOptional(e => e.CarManufacturer)
                .HasForeignKey(e => e.Manufacturer);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.Driver)
                .WithOptional(e => e.Company1)
                .HasForeignKey(e => e.Company);

            modelBuilder.Entity<Job>()
                .HasMany(e => e.Driver)
                .WithOptional(e => e.Job)
                .HasForeignKey(e => e.JobName);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.License)
                .WithOptional(e => e.Status1)
                .HasForeignKey(e => e.Status);

            modelBuilder.Entity<TypeOfDrive>()
                .HasMany(e => e.Car)
                .WithOptional(e => e.TypeOfDrive1)
                .HasForeignKey(e => e.TypeOfDrive);
        }
    }
}
