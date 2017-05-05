namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CRMBOC")]
    public partial class CRMBOC
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string CBONUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SEQNUM { get; set; }

        public DateTime? IDATE { get; set; }

        [StringLength(50)]
        public string OPPORTUNITYSTATUS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PROBABILITY { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        [StringLength(50)]
        public string CREATEDBY { get; set; }

        public DateTime? CREATEDSTAMP { get; set; }

        [StringLength(50)]
        public string UPDATEDBY { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }
    }
}
