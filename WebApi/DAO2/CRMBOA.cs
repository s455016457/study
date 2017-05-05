namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CRMBOA")]
    public partial class CRMBOA
    {
        [Key]
        [StringLength(50)]
        public string CBONUM { get; set; }

        [StringLength(200)]
        public string SUBJECT { get; set; }

        [StringLength(2000)]
        public string CONTENT { get; set; }

        public DateTime? IDATE { get; set; }

        public DateTime? PLANCMPTIME { get; set; }

        public DateTime? ACTUALCMPTIME { get; set; }

        [StringLength(50)]
        public string CUSNUM { get; set; }

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

        [StringLength(500)]
        public string REQUIREMENT { get; set; }

        [StringLength(50)]
        public string OPPORTUNITYSTATUS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PROBABILITY { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TOTALAMOUNT { get; set; }

        [StringLength(500)]
        public string COMPETITORNAME { get; set; }

        [StringLength(500)]
        public string CPTREMARK { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public byte? ISCOMPLETED { get; set; }

        [StringLength(50)]
        public string COMPLETEDUSER { get; set; }

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
