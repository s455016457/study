namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SOPRVB")]
    public partial class SOPRVB
    {
        [Key]
        public int SOPRVB_ID { get; set; }

        public int SOPROREQUIRE_ID { get; set; }

        public int GRAMPB_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string CODE { get; set; }

        public decimal? MIN { get; set; }

        public decimal? MAX { get; set; }

        public decimal? AVG { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDUSER { get; set; }

        public DateTime CREATEDSTAMP { get; set; }

        [StringLength(20)]
        public string UPDATEDUSER { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }
    }
}
