namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RANKING")]
    public partial class RANKING
    {
        [Key]
        [StringLength(20)]
        public string RANKNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        [Required]
        [StringLength(20)]
        public string WONUM { get; set; }

        [Required]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public DateTime CREATED { get; set; }

        [StringLength(10)]
        public string CREATEDBY { get; set; }
    }
}
