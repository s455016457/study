namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MRPSCHEME3
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string MRPCODE { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LINEID { get; set; }

        public int PERIODID { get; set; }

        [Required]
        [StringLength(20)]
        public string ITEMNUM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTITY { get; set; }

        [StringLength(20)]
        public string BASEDOCNUM { get; set; }

        [StringLength(20)]
        public string BASELOT { get; set; }

        public DateTime? BASEDUE { get; set; }

        [StringLength(1)]
        public string STOCKTYPE { get; set; }

        [StringLength(20)]
        public string PARENTCODE { get; set; }

        public DateTime? STARTDATE { get; set; }

        public DateTime? ENDDATE { get; set; }

        [StringLength(20)]
        public string ORDERTYPE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ORIDATE { get; set; }
    }
}
