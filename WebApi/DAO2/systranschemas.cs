namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class systranschemas
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tabid { get; set; }

        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public byte[] startlsn { get; set; }

        [Key]
        [Column(Order = 2)]
        [MaxLength(10)]
        public byte[] endlsn { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int typeid { get; set; }
    }
}
