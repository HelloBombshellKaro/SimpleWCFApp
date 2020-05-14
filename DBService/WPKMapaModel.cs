namespace DBService
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WPKMapaModel : DbContext
    {
        public WPKMapaModel()
            : base("name=WPKMapaModelDB")
        {
        }

        public virtual DbSet<Radar> Radary { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Radar>()
                .Property(e => e.Nazwa)
                .IsUnicode(false);

            modelBuilder.Entity<Radar>()
                .Property(e => e.Wlasciciel)
                .IsUnicode(false);
        }
    }
}
