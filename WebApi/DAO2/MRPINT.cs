namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MRPINT")]
    public partial class MRPINT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string MRPCODE { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SEQNUM { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string DOCTYPE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(30)]
        public string DOCNUM { get; set; }

        [StringLength(30)]
        public string DEPTID { get; set; }

        [StringLength(30)]
        public string VENID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DOCDATE { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        public decimal? ORDERQTY { get; set; }

        public decimal? RECVQTY { get; set; }

        public decimal? REJECTQTY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime RECVDATE { get; set; }

        public decimal? INTRANSITQTY { get; set; }

        [StringLength(200)]
        public string DEPTNAME { get; set; }

        [StringLength(200)]
        public string VENNAME { get; set; }
    }
}
