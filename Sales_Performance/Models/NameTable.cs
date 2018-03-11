namespace Sales_Performance.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NameTable")]
    public partial class NameTable
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int Point_pen { get; set; }

        public int Pencil { get; set; }

        public int Eraser { get; set; }

        public int Ruler { get; set; }

        public int Liquid_paper { get; set; }

        public int Total_sales { get; set; }
    }
}
