namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EOPTON")]
    public partial class EOPTON
    {
        [Key]
        [StringLength(20)]
        public string UID { get; set; }

        public int? RICHTEXTEDITOR { get; set; }

        public int? SAVESENT { get; set; }

        public int? QUOTEREPLY { get; set; }
    }
}
