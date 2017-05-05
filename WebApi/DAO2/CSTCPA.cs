namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CSTCPA")]
    public partial class CSTCPA
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FPERIOD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string WOTYPE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string WONUM { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(30)]
        public string PARTNUM { get; set; }

        [StringLength(50)]
        public string MASTERITEMNUM { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(20)]
        public string MITYPE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? MIDATE { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(20)]
        public string REFPONUM { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(20)]
        public string REFWONUM { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(20)]
        public string LOCID { get; set; }

        public decimal? QTY { get; set; }

        [StringLength(10)]
        public string UOM { get; set; }

        public decimal? UPRICE { get; set; }

        public decimal? AMOUNT { get; set; }

        public int? ISREWORK { get; set; }

        [StringLength(100)]
        public string REMARK { get; set; }

        public int? ISREP { get; set; }

        public decimal? REPRATE { get; set; }

        public decimal? DOSAGE { get; set; }

        public int ISUNLIMITED { get; set; }
    }
}
