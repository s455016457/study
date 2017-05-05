namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CSTBFA")]
    public partial class CSTBFA
    {
        [Key]
        [StringLength(30)]
        public string CSTBFNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CSTBFDATE { get; set; }

        [StringLength(30)]
        public string LOCID { get; set; }

        [StringLength(500)]
        public string REMARKS { get; set; }

        public decimal? TOTALQTY { get; set; }

        public decimal? TOTALAMOUNT { get; set; }

        public int? ISCONFIRMED { get; set; }

        [StringLength(30)]
        public string CREATEDUSER { get; set; }

        public DateTime? CREATEDSTAMP { get; set; }

        [StringLength(30)]
        public string UPDATEDUSER { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }
    }
}
