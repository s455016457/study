namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CRMABA")]
    public partial class CRMABA
    {
        [Key]
        [StringLength(50)]
        public string ABNUM { get; set; }

        [StringLength(50)]
        public string ABNAME { get; set; }

        [StringLength(50)]
        public string ABTYPE { get; set; }

        [StringLength(50)]
        public string SEX { get; set; }

        [StringLength(50)]
        public string TEL { get; set; }

        [StringLength(100)]
        public string MOBILE { get; set; }

        [StringLength(100)]
        public string EMAIL { get; set; }

        [StringLength(100)]
        public string QQ { get; set; }

        [StringLength(100)]
        public string ICQ { get; set; }

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
        public string ADDRESS { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? BIRTHDAY { get; set; }

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
