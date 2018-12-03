namespace ProjectManagment.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=DbModel")
        {
        }

        public virtual DbSet<Marker> Marker { get; set; }
        public virtual DbSet<Requirement> Requirement { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<Accountant> Accountant { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<Task_Requirement> Task_Requirement { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Marker>()
                .Property(e => e.label)
                .IsUnicode(false);

            modelBuilder.Entity<Requirement>()
                .Property(e => e.detail)
                .IsUnicode(false);

            modelBuilder.Entity<Accountant>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Project>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Project>()
                .Property(e => e.trigram)
                .IsUnicode(false);
        }
    }
}
