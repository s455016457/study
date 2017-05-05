namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EINBOX")]
    public partial class EINBOX
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string RECIPIENT { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string FOLDER { get; set; }

        public DateTime? RECDATE { get; set; }

        public int? OPENED { get; set; }

        public int? WASREAD { get; set; }

        public int? DELETED { get; set; }

        public int? STATUS { get; set; }

        public int? ISNEWMAIL { get; set; }

        public DateTime? CREATEDSTAMP { get; set; }
    }
}
