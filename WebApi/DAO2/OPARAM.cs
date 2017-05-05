namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OPARAM")]
    public partial class OPARAM
    {
        [StringLength(1000)]
        public string POCOMMENTS { get; set; }

        [StringLength(1000)]
        public string SCCOMMENTS { get; set; }

        public int? EXISTSSUBPR { get; set; }

        public int? EXISTSPR { get; set; }

        public int? POFIXVENINFO { get; set; }

        public int? SCFIXVENINFO { get; set; }

        public int? POCANNOTUPDATE { get; set; }

        public int? SCCANNOTUPDATE { get; set; }

        public int? ALLOWSCGRNOVERACT { get; set; }

        public decimal? SCGRNOVERACTRATE { get; set; }

        public int? ALLOWOVERMIPLAN { get; set; }

        public decimal? OVERMIPLANRATE { get; set; }

        public int? POVALIDBUYER { get; set; }

        public int? SCVALIDBUYER { get; set; }

        public int? PODIFFPRICE { get; set; }

        public int? SCDIFFPRICE { get; set; }

        public int? REFUNDCHECKRATIO { get; set; }

        public int? ALLOWITEMNOTINPO { get; set; }

        public int? ALLOWITEMNOTINSC { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PURDIFFQTYALLOWPOST { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SCPURDIFFQTYALLOWPOST { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool POCOMPUTEMINPACKQTY { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool PRCOMPUTEMINPACKQTY { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool SCGRNCHECKALLMI { get; set; }
    }
}
