namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSTOMER")]
    public partial class CUSTOMER
    {
        [Key]
        [StringLength(20)]
        public string CUSID { get; set; }

        [Required]
        [StringLength(200)]
        public string CUSNAME { get; set; }

        [StringLength(20)]
        public string SHORTNAME { get; set; }

        [StringLength(10)]
        public string CUSTYPE { get; set; }

        [StringLength(20)]
        public string CURR { get; set; }

        [StringLength(20)]
        public string PAYTERM { get; set; }

        [StringLength(20)]
        public string PAYMETHOD { get; set; }

        [StringLength(20)]
        public string TRADETERM { get; set; }

        [StringLength(20)]
        public string SALESREGION { get; set; }

        [StringLength(50)]
        public string PURCONTACT { get; set; }

        [StringLength(50)]
        public string PURMAIL { get; set; }

        [StringLength(50)]
        public string PURTEL { get; set; }

        [StringLength(50)]
        public string PURFAX { get; set; }

        [StringLength(100)]
        public string PURADDR { get; set; }

        [StringLength(50)]
        public string SHIPTOCONTACT { get; set; }

        [StringLength(50)]
        public string SHIPTOMAIL { get; set; }

        [StringLength(50)]
        public string SHIPTOTEL { get; set; }

        [StringLength(50)]
        public string SHIPTOFAX { get; set; }

        [StringLength(100)]
        public string SHIPTOADDR { get; set; }

        [StringLength(50)]
        public string BILLTOCONTACT { get; set; }

        [StringLength(50)]
        public string BILLTOMAIL { get; set; }

        [StringLength(50)]
        public string BILLTOTEL { get; set; }

        [StringLength(50)]
        public string BILLTOFAX { get; set; }

        [StringLength(100)]
        public string BILLTOADDR { get; set; }

        [StringLength(20)]
        public string SALESREP { get; set; }

        public decimal? CREDITLIMIT { get; set; }

        public decimal? CLBAL { get; set; }

        public decimal? XCREDITLIMIT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? XDATE { get; set; }

        [StringLength(20)]
        public string INVTYPE { get; set; }

        public decimal? TAXRATE { get; set; }

        [StringLength(20)]
        public string RECACC { get; set; }

        [StringLength(20)]
        public string SALESACC { get; set; }

        [StringLength(20)]
        public string ARACC { get; set; }

        [StringLength(20)]
        public string RECTMPACC { get; set; }

        [StringLength(20)]
        public string ORACC { get; set; }

        public int? ISCRLMT { get; set; }

        [StringLength(30)]
        public string INVOUTACC { get; set; }

        [StringLength(200)]
        public string CUSNAME2 { get; set; }

        [StringLength(30)]
        public string ASSISTANT { get; set; }

        public int? ISCRLMTSO { get; set; }

        public int? ISDENY { get; set; }

        [StringLength(20)]
        public string CREATEDUSER { get; set; }

        public DateTime? CREATEDSTAMP { get; set; }

        [StringLength(1000)]
        public string REMARKS { get; set; }

        [StringLength(1000)]
        public string SOREMARKS { get; set; }

        [StringLength(10)]
        public string RANKLEVEL { get; set; }

        [StringLength(20)]
        public string ORDERLEVEL { get; set; }
    }
}
