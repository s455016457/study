namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GRADVC")]
    public partial class GRADVC
    {
        [Key]
        public int GRADVC_ID { get; set; }

        public int GRADATA_ID { get; set; }

        public int GRAMPB_ID { get; set; }

        public int? GRADVD_ID { get; set; }

        [StringLength(10)]
        public string CODE { get; set; }

        public decimal? X { get; set; }

        public decimal? Y { get; set; }

        public decimal? Z { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDUSER { get; set; }

        public DateTime CREATEDSTAMP { get; set; }

        [StringLength(20)]
        public string UPDATEDUSER { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }
    }
}
