namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SPARAM")]
    public partial class SPARAM
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ISCHECKRANK { get; set; }

        public int? DISPRANKDATA { get; set; }

        public int? ALLOWOVERREQ { get; set; }

        public int? ALLOWOVERR { get; set; }

        public int? CHKDEPTID { get; set; }

        public int? UNIONDOCNUM { get; set; }

        public int? ALLOWUPDDATE { get; set; }

        public int? OVERINVENTORY { get; set; }

        public int? ALLOWUPDATEUPRICE { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ALLOWUPDRMK { get; set; }

        public int? DISPCUSNAME { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DICDATEIDENTICAL { get; set; }

        public int? DIFFQTYALLOWPOST { get; set; }

        public int? ALLOWITEMNOTINSO { get; set; }

        public int? REFCONTRACTAPPROVAL { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ALLOWNONEINVOICEAPPLY { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ALLOWNONETAXRATE { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QUOTATIONDTLROWCOUNT { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DELETEENTIRESINV { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DELETEENTIRESR { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AllSONUMNOTINSO { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SRDIFFQTYALLOWPOST { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NEEDQUOTATION { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool UPDATESIMAINTABLEUNCHECKWF { get; set; }
    }
}
