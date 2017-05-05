namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_QCDTLITEM
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string QCNUM { get; set; }

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
        public string WORKPROC { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string INSPITEMID { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(200)]
        public string INSPITEMDESCR { get; set; }

        public decimal? DEFECTQTY { get; set; }
    }
}
