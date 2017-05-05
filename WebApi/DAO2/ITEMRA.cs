namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ITEMRA")]
    public partial class ITEMRA
    {
        [Key]
        [StringLength(30)]
        public string IREPNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        [Required]
        [StringLength(200)]
        public string REMARKS { get; set; }

        public int COMPLETED { get; set; }

        [Required]
        [StringLength(30)]
        public string CREATEDUSER { get; set; }

        public DateTime CREATEDSTAMP { get; set; }

        [StringLength(30)]
        public string UPDATEDUSER { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }
    }
}
