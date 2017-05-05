namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MESSOA")]
    public partial class MESSOA
    {
        [Key]
        [StringLength(20)]
        public string MESSONUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime MESSODATE { get; set; }

        [StringLength(10)]
        public string MESSOTYPE { get; set; }

        [Required]
        [StringLength(20)]
        public string LOCID { get; set; }

        [Required]
        [StringLength(30)]
        public string ORIDOCNUM { get; set; }

        public decimal TOTALQTY { get; set; }

        [StringLength(1000)]
        public string REMARKS { get; set; }

        public int COMPLETED { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDUSER { get; set; }

        public DateTime CREATEDSTAMP { get; set; }

        [StringLength(20)]
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
