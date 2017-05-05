namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CRMATV")]
    public partial class CRMATV
    {
        public long ID { get; set; }

        [StringLength(200)]
        public string SUBJECT { get; set; }

        [StringLength(2000)]
        public string CONTENT { get; set; }

        public DateTime? STARTDATE { get; set; }

        public DateTime? ENDDATE { get; set; }

        public DateTime? ACTENDDATE { get; set; }

        [StringLength(100)]
        public string PERSON { get; set; }

        [StringLength(50)]
        public string STATUS { get; set; }

        [StringLength(50)]
        public string TYPE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AMOUNT { get; set; }

        [StringLength(100)]
        public string REFOBJECT { get; set; }

        [StringLength(100)]
        public string REFKEY { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }

        [StringLength(50)]
        public string CREATEDBY { get; set; }

        public DateTime? CREATEDSTAMP { get; set; }

        [StringLength(50)]
        public string UPDATEDBY { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }
    }
}
