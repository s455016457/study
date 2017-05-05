namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CRMWPB")]
    public partial class CRMWPB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string WPNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string UID { get; set; }

        [StringLength(20)]
        public string DEPTID { get; set; }

        [StringLength(50)]
        public string TELPHONE { get; set; }

        [StringLength(100)]
        public string MOBILE { get; set; }

        [StringLength(100)]
        public string EMAIL { get; set; }

        [StringLength(50)]
        public string CREATEDBY { get; set; }

        public DateTime? CREATEDSTAMP { get; set; }

        [StringLength(50)]
        public string UPDATEDBY { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }
    }
}
