namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SYSTEMINIT")]
    public partial class SYSTEMINIT
    {
        [Key]
        [Column(Order = 0, TypeName = "smalldatetime")]
        public DateTime BEGDATE { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int STARTUPDATA { get; set; }
    }
}
