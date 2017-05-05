namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SOPRVC")]
    public partial class SOPRVC
    {
        [Key]
        public int SOPRVC_ID { get; set; }

        public int SOPROREQUIRE_ID { get; set; }

        public int GRAMPB_ID { get; set; }

        public int? SOPRVD_ID { get; set; }

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
