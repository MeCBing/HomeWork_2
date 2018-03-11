namespace Sales_Performance.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TestModel : DbContext
    {
        public TestModel()
            : base("name=TestModel1")
        {
        }

        public virtual DbSet<NameTable> NameTable { get; set; }
        public virtual DbSet<ProductTable> ProductTable { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
