namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GRACRA")]
    public partial class GRACRA
    {
        [Key]
        public int GRACRA_ID { get; set; }

        [Required]
        [StringLength(500)]
        public string NAME { get; set; }

        [StringLength(100)]
        public string REMARK { get; set; }

        [StringLength(1)]
        public string LABELIDSEPARATOR { get; set; }

        [StringLength(1)]
        public string LABELNAMESEPARATOR_B { get; set; }

        public bool COSTATE { get; set; }

        public DateTime? COSTAMP { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(1)]
        public string OBJTYPE { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDUSER { get; set; }

        public DateTime CREATEDSTAMP { get; set; }

        [StringLength(20)]
        public string UPDATEDUSER { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }
    }
}
