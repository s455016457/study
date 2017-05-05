namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_UNSETSINVFORINVOICE
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string SONUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string SINUM { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string CUSID { get; set; }

        public decimal? AMOUNT { get; set; }

        public decimal? BASEAMOUNT { get; set; }

        public decimal? TAXRATE { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal RATE { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(20)]
        public string CURR { get; set; }

        public decimal? BAL { get; set; }

        public decimal? BASEBAL { get; set; }

        [StringLength(200)]
        public string CUSNAME { get; set; }
    }
}
