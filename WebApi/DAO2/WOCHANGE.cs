namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WOCHANGE")]
    public partial class WOCHANGE
    {
        [Key]
        [StringLength(20)]
        public string WOCNUM { get; set; }

        public DateTime WOCDATE { get; set; }

        [Required]
        [StringLength(20)]
        public string WOCTYPE { get; set; }

        [Required]
        [StringLength(20)]
        public string WONUM { get; set; }

        public decimal WOQTY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime OLDPLANBEGDATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime OLDPLANENDDATE { get; set; }

        [StringLength(500)]
        public string OLDWOREMARK { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime NEWPLANBEGDATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime NEWPLANENDDATE { get; set; }

        [StringLength(500)]
        public string NEWWOREMARK { get; set; }

        public decimal CHANGEQTY { get; set; }

        [StringLength(500)]
        public string WOCREMARK { get; set; }

        public bool COMPLETED { get; set; }

        public DateTime? COMPLETEDSTAMP { get; set; }

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
