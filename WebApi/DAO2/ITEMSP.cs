namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ITEMSP")]
    public partial class ITEMSP
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string SYSTYPE { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SEQNUM { get; set; }

        public decimal QTY1 { get; set; }

        public decimal QTY2 { get; set; }

        public decimal UPRICE1 { get; set; }

        public decimal UPRICE2 { get; set; }

        [Required]
        [StringLength(30)]
        public string LASTAPPNUM { get; set; }

        [StringLength(50)]
        public string CREATEDBY { get; set; }

        public DateTime? CREATEDSTAMP { get; set; }

        [StringLength(50)]
        public string UPDATEDBY { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }

        [StringLength(30)]
        public string CUSVEN { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string CURR { get; set; }
    }
}
