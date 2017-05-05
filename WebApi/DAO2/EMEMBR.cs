namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EMEMBR")]
    public partial class EMEMBR
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string UID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GRPID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string MAILID { get; set; }
    }
}
