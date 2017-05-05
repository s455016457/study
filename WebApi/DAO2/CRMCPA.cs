namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CRMCPA")]
    public partial class CRMCPA
    {
        [Key]
        [StringLength(50)]
        public string CPTNUM { get; set; }

        [StringLength(500)]
        public string COMPETITORNAME { get; set; }

        [StringLength(50)]
        public string COMPETITIVELEVEL { get; set; }

        [StringLength(100)]
        public string SHORTNAME { get; set; }

        [StringLength(50)]
        public string COUNTRY { get; set; }

        [StringLength(50)]
        public string PROVINCE { get; set; }

        [StringLength(50)]
        public string CITY { get; set; }

        [StringLength(50)]
        public string DISTRICT { get; set; }

        [StringLength(100)]
        public string PHONE { get; set; }

        [StringLength(100)]
        public string FAX { get; set; }

        [StringLength(100)]
        public string EMAIL { get; set; }

        [StringLength(500)]
        public string ADDRESS { get; set; }

        [StringLength(100)]
        public string CONTACT { get; set; }

        [StringLength(200)]
        public string WEBSITE { get; set; }

        [StringLength(10)]
        public string ZIPCODE { get; set; }

        [StringLength(500)]
        public string ADVANTAGE { get; set; }

        [StringLength(500)]
        public string CONTRARIAN { get; set; }

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
