namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WOMATERIALB")]
    public partial class WOMATERIALB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string WMINUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        public decimal QTY { get; set; }

        public decimal MIQTY { get; set; }

        public decimal EXQTY { get; set; }

        [Required]
        [StringLength(20)]
        public string UOM { get; set; }

        [StringLength(500)]
        public string REMARKS { get; set; }

        public decimal ISSUEDQTY { get; set; }

        public decimal EXISSUEDQTY { get; set; }

        public decimal? DOSAGE { get; set; }

        public decimal? SCPRATE { get; set; }

        public decimal FREJECTEDQTY { get; set; }

        public bool ISREP { get; set; }

        [StringLength(50)]
        public string MASTERITEMNUM { get; set; }

        public int? SEQNUM { get; set; }

        public decimal? REPRATE { get; set; }

        [Required]
        [StringLength(50)]
        public string CREATEDUSER { get; set; }

        public DateTime CREATEDSTAMP { get; set; }

        [StringLength(50)]
        public string UPDATEDUSER { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }
    }
}
