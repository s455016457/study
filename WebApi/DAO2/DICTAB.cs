namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DICTAB")]
    public partial class DICTAB
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DICTID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DICTFIELDID { get; set; }

        [Required]
        [StringLength(500)]
        public string DICTFIELD { get; set; }

        [Required]
        [StringLength(100)]
        public string DICTFIELDNAME { get; set; }

        [Required]
        [StringLength(100)]
        public string DICTFIELDTYPE { get; set; }

        [StringLength(50)]
        public string CTLTYPE { get; set; }

        [StringLength(1000)]
        public string DATASRC { get; set; }

        [StringLength(50)]
        public string DATAVALUE { get; set; }

        [StringLength(50)]
        public string DATATEXT { get; set; }
    }
}
