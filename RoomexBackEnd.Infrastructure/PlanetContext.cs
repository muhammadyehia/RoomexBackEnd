using System.Data.Entity.Infrastructure.Annotations;
using RoomexBackEnd.Core.Entities;

namespace RoomexBackEnd.Infrastructure
{
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class PlanetContext : DbContext
    {
        public PlanetContext()
            : base("name=PlanetContext")
        {
            Database.SetInitializer<PlanetContext>(new CreateDatabaseIfNotExists<PlanetContext>());
        }

        public virtual DbSet<Planet> Planets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Planet>().HasKey(c => c.PlanetId);
            modelBuilder.Entity<Planet>().Property(c => c.Name).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Planet>()
                .Property(c => c.Name)
                .HasColumnAnnotation("Index",
                    new IndexAnnotation(new IndexAttribute("IX_Planet_Name") {IsUnique = true}));
        }
    }
}
