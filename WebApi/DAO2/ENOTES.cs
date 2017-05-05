namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ENOTES
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NID { get; set; }

        [StringLength(2)]
        public string TYPE { get; set; }

        public int? PRIORITY { get; set; }

        [StringLength(100)]
        public string SENDBY { get; set; }

        [StringLength(1000)]
        public string RECIPIENTS { get; set; }

        [StringLength(1000)]
        public string COPYRECIPIENTS { get; set; }

        [StringLength(500)]
        public string SUBJECT { get; set; }

        [Column(TypeName = "ntext")]
        public string MESSAGE { get; set; }

        [StringLength(100)]
        public string DATAPARAMS { get; set; }

        [StringLength(200)]
        public string MSGDATA { get; set; }

        [StringLength(100)]
        public string ATTACHMENT { get; set; }

        public int? WASSENT { get; set; }

        public DateTime? SENDSTAMP { get; set; }
    }
}
