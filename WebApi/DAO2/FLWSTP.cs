namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FLWSTP")]
    public partial class FLWSTP
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WFID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int STPID { get; set; }

        [Required]
        [StringLength(200)]
        public string STPNAME { get; set; }

        public int TOBEEND { get; set; }

        public int FLWRULE { get; set; }

        [StringLength(300)]
        public string REMARK { get; set; }

        public int SORTID { get; set; }

        public int? ALLOWPRINT { get; set; }

        public int? MAILNOTIFY { get; set; }
    }
}
