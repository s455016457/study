namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APAYDC")]
    public partial class APAYDC
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string APNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LINEID { get; set; }

        [Required]
        [StringLength(20)]
        public string ACCNUM { get; set; }

        [Required]
        [StringLength(100)]
        public string LINEMEMO { get; set; }

        public decimal DEBIT { get; set; }

        [Required]
        [StringLength(500)]
        public string REMARKS { get; set; }

        public DateTime? CREATEDSTAMP { get; set; }

        [StringLength(20)]
        public string CREATEDUSER { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }

        [StringLength(20)]
        public string UPDATEDUSER { get; set; }
    }
}
