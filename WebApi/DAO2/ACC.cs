namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACC")]
    public partial class ACC
    {
        [Key]
        [StringLength(20)]
        public string CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string NAME { get; set; }

        [StringLength(20)]
        public string PARENT { get; set; }

        [Required]
        [StringLength(10)]
        public string TYPE { get; set; }

        public decimal? BAL { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? BALDATE { get; set; }

        public decimal? BAL1 { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? BALDATE1 { get; set; }

        public int NORMAL { get; set; }

        public decimal DR { get; set; }

        public decimal CR { get; set; }

        public decimal YDR { get; set; }

        public decimal YCR { get; set; }

        public int ISCASH { get; set; }

        public int ISBANK { get; set; }

        public int CHILDS { get; set; }

        [StringLength(200)]
        public string FULLNAME { get; set; }

        public int? ISINPUTVAT { get; set; }

        public int? ISOUTPUTVAT { get; set; }

        public int? ISTEMPRECACC { get; set; }

        public int? ISTEMPPAYACC { get; set; }
    }
}
