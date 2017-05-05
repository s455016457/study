namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MRPRESULT")]
    public partial class MRPRESULT
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LINEID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string MRPCODE { get; set; }

        [Required]
        [StringLength(20)]
        public string ITEMNUM { get; set; }

        public DateTime? DUEDATE { get; set; }

        [StringLength(10)]
        public string ORDERTYPE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTITY { get; set; }

        [StringLength(10)]
        public string UOM { get; set; }

        [StringLength(10)]
        public string ORIGIN { get; set; }

        [StringLength(1)]
        public string STATUS { get; set; }

        public DateTime DOCDATE { get; set; }
    }
}
