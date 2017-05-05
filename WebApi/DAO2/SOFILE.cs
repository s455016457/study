namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SOFILE")]
    public partial class SOFILE
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string SONUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SEQNUM { get; set; }

        [Required]
        [StringLength(200)]
        public string FILENAME { get; set; }

        [Required]
        [StringLength(100)]
        public string CONTENTTYPE { get; set; }

        [Required]
        [StringLength(400)]
        public string FILEPATH { get; set; }

        [Required]
        [StringLength(20)]
        public string DEPTID { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        [Required]
        [StringLength(50)]
        public string CREATEDBY { get; set; }

        public DateTime CREATED { get; set; }

        [StringLength(50)]
        public string UPDATEDUSER { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }
    }
}
