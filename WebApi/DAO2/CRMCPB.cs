namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CRMCPB")]
    public partial class CRMCPB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string CPTNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SEQNUM { get; set; }

        [StringLength(500)]
        public string PRODUCTINFO { get; set; }

        [StringLength(500)]
        public string PRICEINFO { get; set; }

        [StringLength(500)]
        public string ADVANTAGE { get; set; }

        [StringLength(500)]
        public string CONTRARIAN { get; set; }

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
