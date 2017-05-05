namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VOUENY")]
    public partial class VOUENY
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string VID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LINEID { get; set; }

        [Required]
        [StringLength(20)]
        public string ACCNUM { get; set; }

        [StringLength(500)]
        public string LINEMEMO { get; set; }

        public decimal ORIAMT { get; set; }

        public decimal RATE { get; set; }

        [Required]
        [StringLength(20)]
        public string CURRCODE { get; set; }

        public decimal DEBIT { get; set; }

        public decimal CREDIT { get; set; }
    }
}
