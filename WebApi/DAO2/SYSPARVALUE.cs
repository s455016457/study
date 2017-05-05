namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SYSPARVALUE")]
    public partial class SYSPARVALUE
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string PARID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string VALUEID { get; set; }

        [Required]
        [StringLength(500)]
        public string NAME { get; set; }

        public decimal VALUE { get; set; }

        [StringLength(100)]
        public string REMARK { get; set; }

        public int ORD { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDUSER { get; set; }

        public DateTime CREATEDSTAMP { get; set; }

        [StringLength(20)]
        public string UPDATEDUSER { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }
    }
}
