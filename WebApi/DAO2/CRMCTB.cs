namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CRMCTB")]
    public partial class CRMCTB
    {
        [Key]
        [StringLength(50)]
        public string CTBNUM { get; set; }

        [StringLength(50)]
        public string CUSNUM { get; set; }

        public DateTime? CONTACTDATE { get; set; }

        public DateTime? ACTUALCMPTIME { get; set; }

        [StringLength(50)]
        public string CONTACTTYPE { get; set; }

        [StringLength(200)]
        public string SUBJECT { get; set; }

        [StringLength(2000)]
        public string CONTENT { get; set; }

        [StringLength(50)]
        public string PURPOSE { get; set; }

        [StringLength(50)]
        public string MEANS { get; set; }

        [StringLength(100)]
        public string CONTACTNAME { get; set; }

        [StringLength(100)]
        public string CONTACTTEL { get; set; }

        [StringLength(100)]
        public string CONTACTFAX { get; set; }

        [StringLength(100)]
        public string CONTACTMOBILE { get; set; }

        [StringLength(100)]
        public string CONTACTEMAIL { get; set; }

        [StringLength(200)]
        public string DEPTNAME { get; set; }

        [StringLength(200)]
        public string USERNAME { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EXPENSE { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }

        [StringLength(20)]
        public string DEPTID { get; set; }

        [StringLength(50)]
        public string CREATEDBY { get; set; }

        public DateTime? CREATEDSTAMP { get; set; }

        [StringLength(50)]
        public string UPDATEDBY { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }
    }
}
