namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FLWTPL")]
    public partial class FLWTPL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WFID { get; set; }

        [Required]
        [StringLength(100)]
        public string WFNAME { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        [Required]
        [StringLength(100)]
        public string MID { get; set; }

        [Required]
        [StringLength(20)]
        public string DEPTID { get; set; }

        public DateTime? CREATED { get; set; }

        [StringLength(30)]
        public string CREATEDBY { get; set; }

        public DateTime? UPDATESTAMP { get; set; }

        [StringLength(30)]
        public string UPDATEUSER { get; set; }

        public int? DENYOTHER { get; set; }

        public int? ISCANCELED { get; set; }
    }
}
