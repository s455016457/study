namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MRPRLT")]
    public partial class MRPRLT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string MRPCODE { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SEQNUM { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        public decimal? SAFETYSTOCK { get; set; }

        public decimal? INSTOCK { get; set; }

        public decimal? INTRANSIT { get; set; }

        public decimal? OUTSTOCK { get; set; }

        public decimal? REQUESTS { get; set; }

        public decimal? AVAILABLEQTY { get; set; }
    }
}
