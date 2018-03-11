namespace Transportation.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TransportatiionModel : DbContext
    {
        public TransportatiionModel()
            : base("name=TransportatiionModel1")
        {
        }

        public virtual DbSet<TransportatiionTable> TransportatiionTable { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TransportatiionTable>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);
        }
    }
}
