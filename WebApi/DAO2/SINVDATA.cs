namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SINVDATA")]
    public partial class SINVDATA
    {
        public int ID { get; set; }

        [StringLength(30)]
        public string SINUM { get; set; }

        [Required]
        [StringLength(200)]
        public string CUSSHORTNAME { get; set; }

        public DateTime? SIDATE { get; set; }

        [StringLength(30)]
        public string CUSPONUM { get; set; }

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

        public decimal? QTY1 { get; set; }

        public decimal? SOQTY { get; set; }

        public decimal? QTY { get; set; }

        public decimal? QTY2 { get; set; }

        public decimal? UPRICE { get; set; }

        public decimal? AMOUNT { get; set; }

        [StringLength(100)]
        public string UOM { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public bool ISGENSI { get; set; }

        [Required]
        [StringLength(30)]
        public string CREATEDUSER { get; set; }

        public DateTime CREATEDSTAMP { get; set; }

        [StringLength(30)]
        public string UPDATEDUSER { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }
    }
}
