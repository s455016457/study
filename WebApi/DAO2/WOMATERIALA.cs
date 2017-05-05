namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WOMATERIALA")]
    public partial class WOMATERIALA
    {
        [Key]
        [StringLength(20)]
        public string WMINUM { get; set; }

        public DateTime WMIDATE { get; set; }

        [Required]
        [StringLength(20)]
        public string WONUM { get; set; }

        [Required]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [StringLength(20)]
        public string ECNNUM { get; set; }

        [StringLength(20)]
        public string SCHEMENUM { get; set; }

        public decimal QTY { get; set; }

        [StringLength(20)]
        public string DEPTID { get; set; }

        [StringLength(500)]
        public string REMARKS { get; set; }

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
