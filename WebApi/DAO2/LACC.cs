namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LACC")]
    public partial class LACC
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string CODE { get; set; }

        [StringLength(20)]
        public string PARENT { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string NAME { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string TYPE { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal DR { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal CR { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NORMAL { get; set; }
    }
}
