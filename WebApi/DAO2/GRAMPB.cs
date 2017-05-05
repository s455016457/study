namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GRAMPB")]
    public partial class GRAMPB
    {
        [Key]
        public int GRAMPB_ID { get; set; }

        public int GRAMPA_ID { get; set; }

        public int? COORAA_ID { get; set; }

        [StringLength(50)]
        public string DATATYPE { get; set; }

        [StringLength(50)]
        public string SHOWNAME { get; set; }

        [StringLength(10)]
        public string UOM { get; set; }

        [StringLength(20)]
        public string FONTCOLOUR { get; set; }

        public int SEQNUM { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDUSER { get; set; }

        public DateTime CREATEDSTAMP { get; set; }

        [StringLength(20)]
        public string UPDATEDUSER { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }
    }
}
