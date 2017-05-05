namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BTNMNU")]
    public partial class BTNMNU
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string MID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ITEMID { get; set; }

        [Required]
        [StringLength(100)]
        public string ITEMNAME { get; set; }

        [StringLength(100)]
        public string ITEMDESCR { get; set; }

        [Required]
        [StringLength(20)]
        public string ITEMTYPE { get; set; }

        [Required]
        [StringLength(1000)]
        public string ITEMACTION { get; set; }

        [Required]
        [StringLength(100)]
        public string ITEMREPORTNAME { get; set; }

        [Required]
        [StringLength(1000)]
        public string ITEMSCRIPT { get; set; }
    }
}
