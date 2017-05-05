namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BANKAC")]
    public partial class BANKAC
    {
        public int ID { get; set; }

        [Required]
        [StringLength(200)]
        public string BANKNAME { get; set; }

        [Required]
        [StringLength(50)]
        public string ACCOUNTNUM { get; set; }

        [Required]
        [StringLength(200)]
        public string ACCOUNTNAME { get; set; }

        [Required]
        [StringLength(100)]
        public string CURRTYPE { get; set; }

        [Required]
        [StringLength(30)]
        public string CREATEDBY { get; set; }

        public DateTime CREATED { get; set; }

        [StringLength(30)]
        public string UPDATEDUSER { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }
    }
}
