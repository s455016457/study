namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MRPSCA")]
    public partial class MRPSCA
    {
        [Key]
        [StringLength(30)]
        public string MRPCODE { get; set; }

        [StringLength(100)]
        public string DESCR { get; set; }

        [StringLength(50)]
        public string ITEMNUM1 { get; set; }

        [StringLength(50)]
        public string ITEMNUM2 { get; set; }

        public int? EXISTSTOCK { get; set; }

        public int? PURCHREQ { get; set; }

        public int? PURCHORDER { get; set; }

        public int? SALESORDER { get; set; }

        public int? WORKORDER { get; set; }

        public int? SAFETYQTY { get; set; }

        public int? SALESFORECAST { get; set; }

        public int? REPMATERIAL { get; set; }

        public int ISRUNNING { get; set; }

        [StringLength(20)]
        public string EXECUSER { get; set; }

        public DateTime? EXECSTAMP { get; set; }

        public int SEQNUM { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDUSER { get; set; }

        public DateTime CREATEDSTAMP { get; set; }

        [StringLength(20)]
        public string UPDATEDUSER { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }

        public bool MATERIALREQUISITION { get; set; }

        public bool MRPWORKORDER { get; set; }

        public bool MRPMATERIALREQUISITION { get; set; }
    }
}
