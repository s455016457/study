namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VENEVA")]
    public partial class VENEVA
    {
        [Key]
        [StringLength(20)]
        public string VENUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        [Required]
        [StringLength(20)]
        public string VENID { get; set; }

        [Required]
        [StringLength(100)]
        public string VENNAME { get; set; }

        [StringLength(200)]
        public string VENNAME2 { get; set; }

        [StringLength(20)]
        public string VENTYPE { get; set; }

        [StringLength(20)]
        public string CURR { get; set; }

        [StringLength(20)]
        public string PAYTERM { get; set; }

        [StringLength(20)]
        public string PAYMETHOD { get; set; }

        [StringLength(20)]
        public string TRADETERM { get; set; }

        [StringLength(50)]
        public string SALESCONTACT { get; set; }

        [StringLength(100)]
        public string SALESMAIL { get; set; }

        [StringLength(100)]
        public string SALESTEL { get; set; }

        [StringLength(100)]
        public string SALESFAX { get; set; }

        [StringLength(100)]
        public string SALESADDR { get; set; }

        [StringLength(100)]
        public string ACCCONTACT { get; set; }

        [StringLength(100)]
        public string ACCMAIL { get; set; }

        [StringLength(100)]
        public string ACCTEL { get; set; }

        [StringLength(100)]
        public string ACCFAX { get; set; }

        [StringLength(100)]
        public string ACCADDR { get; set; }

        public decimal? TAXRATE { get; set; }

        [StringLength(20)]
        public string TMPAYACC { get; set; }

        [StringLength(20)]
        public string PURACC { get; set; }

        [StringLength(20)]
        public string PAYACC { get; set; }

        [StringLength(20)]
        public string APACC { get; set; }

        [StringLength(20)]
        public string OPACC { get; set; }

        [StringLength(20)]
        public string BUYER { get; set; }

        [StringLength(20)]
        public string INVTYPE { get; set; }

        [StringLength(100)]
        public string WEBSITE { get; set; }

        [StringLength(50)]
        public string SHORTNAME { get; set; }

        [StringLength(50)]
        public string INDUSTRY { get; set; }

        [StringLength(50)]
        public string MOBILE { get; set; }

        [StringLength(50)]
        public string ZIP { get; set; }

        [StringLength(100)]
        public string BANKACC { get; set; }

        [StringLength(100)]
        public string BANK { get; set; }

        [StringLength(30)]
        public string TMTAXACC { get; set; }

        [StringLength(10)]
        public string RANKTYPE { get; set; }

        public int? ISDENY { get; set; }

        [StringLength(20)]
        public string SCACC { get; set; }

        public int ISCONFIRMED { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime CREATED { get; set; }

        [StringLength(20)]
        public string UPDATEUSER { get; set; }

        public DateTime? UPDATESTAMP { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }
    }
}
