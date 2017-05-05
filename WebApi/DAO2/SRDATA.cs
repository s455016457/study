namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SRDATA")]
    public partial class SRDATA
    {
        public int ID { get; set; }

        [StringLength(30)]
        public string SRNUM { get; set; }

        [Required]
        [StringLength(200)]
        public string CUSSHORTNAME { get; set; }

        public DateTime? SRDATE { get; set; }

        [StringLength(30)]
        public string PSNUM { get; set; }

        [StringLength(100)]
        public string STYLE { get; set; }

        [StringLength(100)]
        public string STYLETYPE { get; set; }

        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [StringLength(500)]
        public string ITEMDESCR { get; set; }

        public decimal? QTY { get; set; }

        public decimal? UPRICE { get; set; }

        public decimal? AMOUNT { get; set; }

        [StringLength(100)]
        public string UOM { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public bool ISGENSR { get; set; }

        [Required]
        [StringLength(30)]
        public string CREATEDUSER { get; set; }

        public DateTime CREATEDSTAMP { get; set; }

        [StringLength(30)]
        public string UPDATEDUSER { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }
    }
}
