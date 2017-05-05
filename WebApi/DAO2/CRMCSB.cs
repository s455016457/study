namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CRMCSB")]
    public partial class CRMCSB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string CSNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QTY { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PRICE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AMOUNT { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        [StringLength(50)]
        public string CREATEDBY { get; set; }

        public DateTime? CREATEDSTAMP { get; set; }

        [StringLength(50)]
        public string UPDATEDBY { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }
    }
}
