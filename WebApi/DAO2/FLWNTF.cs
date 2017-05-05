namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FLWNTF")]
    public partial class FLWNTF
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WFID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int STPID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string RESTYPE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string USRID { get; set; }
    }
}
