namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CRMCTA")]
    public partial class CRMCTA
    {
        [Key]
        [StringLength(50)]
        public string CTANUM { get; set; }

        [StringLength(50)]
        public string CUSNUM { get; set; }

        [StringLength(50)]
        public string RELATION { get; set; }

        [StringLength(100)]
        public string CONTACTNAME { get; set; }

        [StringLength(50)]
        public string SEX { get; set; }

        [StringLength(50)]
        public string FAMILY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? BIRTHDAY { get; set; }

        [StringLength(50)]
        public string EDUCATION { get; set; }

        [StringLength(500)]
        public string GRADUATESCHOOL { get; set; }

        [StringLength(50)]
        public string MARITALSTATUS { get; set; }

        [StringLength(100)]
        public string DEPARTMENT { get; set; }

        [StringLength(100)]
        public string POSITION { get; set; }

        [StringLength(50)]
        public string IMPORTANCE { get; set; }

        [StringLength(10)]
        public string ZIPCODE { get; set; }

        [StringLength(500)]
        public string ADDRESS { get; set; }

        [StringLength(100)]
        public string OFFICEPHONE { get; set; }

        [StringLength(100)]
        public string OFFICEFAX { get; set; }

        [StringLength(100)]
        public string HOMEPHONE { get; set; }

        [StringLength(100)]
        public string MOBILE { get; set; }

        [StringLength(100)]
        public string EMAIL { get; set; }

        [StringLength(100)]
        public string QQ { get; set; }

        [StringLength(100)]
        public string MSN { get; set; }

        [StringLength(100)]
        public string ALIIM { get; set; }

        [StringLength(100)]
        public string YAHOO { get; set; }

        [StringLength(100)]
        public string GOOGLE { get; set; }

        [StringLength(100)]
        public string WEIBO { get; set; }

        [StringLength(500)]
        public string OTHERIM { get; set; }

        [StringLength(500)]
        public string HOBBY { get; set; }

        public byte? ISPRIMARYCONTACT { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        [StringLength(50)]
        public string CREATEDBY { get; set; }

        public DateTime? CREATEDSTAMP { get; set; }

        [StringLength(50)]
        public string UPDATEDBY { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }
    }
}
