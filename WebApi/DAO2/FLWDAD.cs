namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FLWDAD")]
    public partial class FLWDAD
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FDID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int STPID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string USRID { get; set; }

        [StringLength(1)]
        public string FSTATUS { get; set; }

        [StringLength(1000)]
        public string REMARKS { get; set; }

        public DateTime? CREATED { get; set; }

        public DateTime? UPDATESTAMP { get; set; }

        [StringLength(100)]
        public string STPNAME { get; set; }

        public int? SORTID { get; set; }

        public int? ALLOWPRINT { get; set; }

        public int? TOBEEND { get; set; }

        public int? FLWRULE { get; set; }

        public int? WFID { get; set; }

        public int? WAITING { get; set; }

        [StringLength(30)]
        public string AGENTUID { get; set; }

        [StringLength(30)]
        public string APPROVALBY { get; set; }

        public int? MAILNOTIFY { get; set; }
    }
}
