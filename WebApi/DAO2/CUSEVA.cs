namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSEVA")]
    public partial class CUSEVA
    {
        [Key]
        [StringLength(20)]
        public string CENUM { get; set; }

        [Required]
        [StringLength(20)]
        public string CUSID { get; set; }

        [Required]
        [StringLength(200)]
        public string CUSNAME { get; set; }

        [StringLength(20)]
        public string SHORTNAME { get; set; }

        [Required]
        [StringLength(10)]
        public string CUSTYPE { get; set; }

        [Required]
        [StringLength(20)]
        public string CURR { get; set; }

        [StringLength(20)]
        public string INVTYPE { get; set; }

        public decimal? TAXRATE { get; set; }

        [Required]
        [StringLength(20)]
        public string PAYTERM { get; set; }

        [Required]
        [StringLength(20)]
        public string PAYMETHOD { get; set; }

        [Required]
        [StringLength(20)]
        public string TRADETERM { get; set; }

        [Required]
        [StringLength(20)]
        public string SALESREGION { get; set; }

        [StringLength(20)]
        public string SALESREP { get; set; }

        public decimal? CREDITLIMIT { get; set; }

        public int? ISCRLMT { get; set; }

        public decimal? REGISTERCAPITAL { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? REGISTERDATE { get; set; }

        public decimal? VALIDPERIOD { get; set; }

        [StringLength(200)]
        public string BUSINESSSCOPE { get; set; }

        [StringLength(100)]
        public string LEGALMASTER { get; set; }

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
        public string RECACC { get; set; }

        [StringLength(20)]
        public string SALESACC { get; set; }

        [StringLength(20)]
        public string ARACC { get; set; }

        [StringLength(20)]
        public string RECTMPACC { get; set; }

        [StringLength(20)]
        public string ORACC { get; set; }

        [StringLength(30)]
        public string INVOUTACC { get; set; }

        public int ISCONFIRMED { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime CREATED { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? IDATE { get; set; }

        [StringLength(10)]
        public string RANKLEVEL { get; set; }
    }
}
