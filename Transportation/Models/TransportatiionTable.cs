namespace Transportation.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransportatiionTable")]
    public partial class TransportatiionTable
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string StartState { get; set; }

        [Required]
        [StringLength(50)]
        public string EndState { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }
    }
}
