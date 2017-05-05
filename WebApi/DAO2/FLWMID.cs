namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FLWMID")]
    public partial class FLWMID
    {
        [Key]
        [StringLength(100)]
        public string MID { get; set; }

        [StringLength(200)]
        public string SRCPATH { get; set; }

        [StringLength(50)]
        public string TABLENAME { get; set; }

        [StringLength(50)]
        public string PKFIELD { get; set; }

        public int? ISWFSTART { get; set; }

        [StringLength(50)]
        public string DETAILTABLENAME { get; set; }

        [StringLength(50)]
        public string DETAILPKFIELD { get; set; }
    }
}
