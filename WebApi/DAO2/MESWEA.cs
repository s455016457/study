namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MESWEA")]
    public partial class MESWEA
    {
        [Key]
        [StringLength(20)]
        public string MESWENUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime MESWEDATE { get; set; }

        [StringLength(10)]
        public string MESWETYPE { get; set; }

        [Required]
        [StringLength(20)]
        public string LOCID { get; set; }

        [Required]
        [StringLength(30)]
        public string WONUM { get; set; }

        public decimal? TOTALQTY { get; set; }

        [StringLength(1000)]
        public string REMARKS { get; set; }

        public int? COMPLETED { get; set; }

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
