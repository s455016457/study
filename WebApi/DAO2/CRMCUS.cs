namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CRMCUS
    {
        [Key]
        [StringLength(50)]
        public string CUSNUM { get; set; }

        [StringLength(500)]
        public string CUSNAME { get; set; }

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

        [StringLength(50)]
        public string SALESREGION { get; set; }

        [StringLength(50)]
        public string SALESREP { get; set; }

        [StringLength(50)]
        public string ASSISTANT { get; set; }

        [StringLength(50)]
        public string CUSTYPE { get; set; }

        [StringLength(50)]
        public string CUSLEVEL { get; set; }

        [StringLength(50)]
        public string PRICELEVEL { get; set; }

        [StringLength(50)]
        public string STATUS { get; set; }

        [StringLength(50)]
        public string SOURCE { get; set; }

        [StringLength(50)]
        public string INDUSTRY { get; set; }

        [StringLength(50)]
        public string CREDITLEVEL { get; set; }

        [StringLength(50)]
        public string NATURE { get; set; }

        [StringLength(50)]
        public string SCALE { get; set; }

        [StringLength(100)]
        public string BUSINESSLICENSE { get; set; }

        [StringLength(100)]
        public string BANKACC { get; set; }

        [StringLength(100)]
        public string BANKNAME { get; set; }

        [StringLength(100)]
        public string TAXNAME { get; set; }

        [StringLength(100)]
        public string TAXACCOUNT { get; set; }

        [StringLength(100)]
        public string TAXBANKACC { get; set; }

        [StringLength(100)]
        public string TAXBANKNAME { get; set; }

        [StringLength(100)]
        public string TAXADDRESS { get; set; }

        [StringLength(100)]
        public string TAXPHONE { get; set; }

        [StringLength(50)]
        public string PAYTERM { get; set; }

        [StringLength(50)]
        public string PAYMETHOD { get; set; }

        [StringLength(50)]
        public string TRADETERM { get; set; }

        [StringLength(50)]
        public string CURR { get; set; }

        [StringLength(50)]
        public string INVTYPE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TAXRATE { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        [StringLength(50)]
        public string REFCUSID { get; set; }

        public DateTime? LASTCONTACTTIME { get; set; }

        public DateTime? NEXTCONTACTTIME { get; set; }

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
