namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CRMCSA")]
    public partial class CRMCSA
    {
        [Key]
        [StringLength(50)]
        public string CSNUM { get; set; }

        public DateTime? IDATE { get; set; }

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

        [StringLength(200)]
        public string SUBJECT { get; set; }

        [StringLength(2000)]
        public string CONTENT { get; set; }

        [StringLength(50)]
        public string CSTYPE { get; set; }

        [StringLength(500)]
        public string CSINFO { get; set; }

        [StringLength(200)]
        public string REFDEPTID { get; set; }

        [StringLength(200)]
        public string REFUSERID { get; set; }

        [StringLength(200)]
        public string PROCDEPTID { get; set; }

        [StringLength(200)]
        public string PROCUSERID { get; set; }

        [StringLength(500)]
        public string PROCRESULT { get; set; }

        [StringLength(50)]
        public string SATISFACTION { get; set; }

        [StringLength(20)]
        public string RETUSERID { get; set; }

        public DateTime? RETIDATE { get; set; }

        [StringLength(500)]
        public string RETRESULT { get; set; }

        public byte? ISCOMPLETED { get; set; }

        public DateTime? ACTUALCMPIME { get; set; }

        [StringLength(50)]
        public string COMPLETEDUSER { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public byte? SUBMIT { get; set; }

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
