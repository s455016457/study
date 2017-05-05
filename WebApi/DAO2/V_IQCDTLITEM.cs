namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_IQCDTLITEM
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string IQCNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SEQNUM { get; set; }

        [StringLength(10)]
        public string QCMETHOD { get; set; }

        [StringLength(20)]
        public string QCITEM { get; set; }

        [StringLength(80)]
        public string QCUNIT { get; set; }

        public decimal? LOWERLIMITQTY { get; set; }

        public decimal? UPPERLIMITQTY { get; set; }

        public decimal? TARGETQTY { get; set; }

        public decimal? PASSQTY { get; set; }

        public decimal? SAMPLEQTY { get; set; }

        public decimal? SAMPLEPASSQTY { get; set; }

        public int? RESULT { get; set; }

        [StringLength(255)]
        public string REMARK { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string CODE { get; set; }

        [StringLength(100)]
        public string DESCR { get; set; }

        [StringLength(20)]
        public string ANALYMETHOD { get; set; }

        [StringLength(20)]
        public string INSPBASIS { get; set; }

        [StringLength(20)]
        public string QCITEMETHOD { get; set; }

        [StringLength(20)]
        public string INSPTOOL { get; set; }

        [StringLength(20)]
        public string SAMPSTD { get; set; }

        [StringLength(20)]
        public string UOM { get; set; }

        public int? CRITICALCHK { get; set; }

        [StringLength(20)]
        public string DEFECTGRADE { get; set; }

        public decimal? DEFECTQTY { get; set; }
    }
}
