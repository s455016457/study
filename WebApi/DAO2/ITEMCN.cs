namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ITEMCN")]
    public partial class ITEMCN
    {
        [Key]
        [StringLength(20)]
        public string ITEMCNNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime ITEMCNDATE { get; set; }

        [Required]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [Required]
        [StringLength(500)]
        public string OLDITEMDESCR { get; set; }

        [Required]
        [StringLength(500)]
        public string NEWITEMDESCR { get; set; }

        [Required]
        [StringLength(500)]
        public string OLDSPEC { get; set; }

        [Required]
        [StringLength(500)]
        public string NEWSPEC { get; set; }

        [StringLength(500)]
        public string REMARKS { get; set; }

        public int? COMPLETED { get; set; }

        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime? CREATED { get; set; }

        [StringLength(20)]
        public string UPDATEUSER { get; set; }

        public DateTime? UPDATESTAMP { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }
    }
}
