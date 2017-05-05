namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COMINF")]
    public partial class COMINF
    {
        [Key]
        [StringLength(100)]
        public string COMPNAMECHN { get; set; }

        [StringLength(100)]
        public string COMPNAMEENG { get; set; }

        [StringLength(10)]
        public string CURR { get; set; }

        [StringLength(140)]
        public string ADDRCHN { get; set; }

        [StringLength(140)]
        public string ADDRENG { get; set; }

        [StringLength(20)]
        public string TEL1 { get; set; }

        [StringLength(20)]
        public string TEL2 { get; set; }

        [StringLength(20)]
        public string FAX { get; set; }

        [StringLength(20)]
        public string ZIP { get; set; }

        [StringLength(50)]
        public string COUNTRY { get; set; }

        [StringLength(100)]
        public string WEBSITE { get; set; }

        [StringLength(100)]
        public string EMAIL { get; set; }

        [StringLength(50)]
        public string MASTER { get; set; }

        [StringLength(20)]
        public string SINSUREACC { get; set; }

        [StringLength(20)]
        public string SHANDLEACC { get; set; }

        [StringLength(20)]
        public string PINSUREACC { get; set; }

        [StringLength(20)]
        public string PHANDLEACC { get; set; }

        [StringLength(20)]
        public string SALESTAXACC { get; set; }

        [StringLength(20)]
        public string PURTAXACC { get; set; }

        [StringLength(20)]
        public string TRANSACC { get; set; }

        public int? STARTYEAR { get; set; }

        public int? STARTPERIOD { get; set; }

        public int? ACTYEAR { get; set; }

        public int? ACTPERIOD { get; set; }

        public int? DECIMALS { get; set; }

        public int? STARTUP { get; set; }

        [StringLength(50)]
        public string PCONTACT { get; set; }

        [StringLength(50)]
        public string PEMAIL { get; set; }

        [StringLength(50)]
        public string PTEL { get; set; }

        [StringLength(50)]
        public string PFAX { get; set; }

        [StringLength(50)]
        public string SCONTACT { get; set; }

        [StringLength(50)]
        public string SEMAIL { get; set; }

        [StringLength(50)]
        public string STEL { get; set; }

        [StringLength(50)]
        public string SFAX { get; set; }

        [StringLength(50)]
        public string WCONTACT { get; set; }

        [StringLength(50)]
        public string WEMAIL { get; set; }

        [StringLength(50)]
        public string WTEL { get; set; }

        [StringLength(50)]
        public string WFAX { get; set; }

        [StringLength(100)]
        public string WADDRESS { get; set; }

        [StringLength(1000)]
        public string LICENSECODE { get; set; }

        public int? LICENSEUSER { get; set; }

        [StringLength(20)]
        public string VERCODE { get; set; }

        [StringLength(200)]
        public string REPORTSPATH { get; set; }

        [StringLength(500)]
        public string LOGOPATH { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EXPIRED { get; set; }
    }
}
