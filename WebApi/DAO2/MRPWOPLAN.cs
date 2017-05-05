namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MRPWOPLAN")]
    public partial class MRPWOPLAN
    {
        [Key]
        [StringLength(20)]
        public string WPNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime PLANBEGDATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime PLANENDDATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime VALIDITYDATE { get; set; }

        [Required]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [StringLength(20)]
        public string ECNNUM { get; set; }

        [StringLength(20)]
        public string SCHEMENUM { get; set; }

        public decimal WOQTY { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public int CLOSED { get; set; }

        public DateTime? CLOSEDSTAMP { get; set; }

        [Required]
        [StringLength(50)]
        public string CREATEDUSER { get; set; }

        public DateTime CREATEDSTAMP { get; set; }

        [StringLength(50)]
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
