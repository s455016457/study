namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APPTKT")]
    public partial class APPTKT
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        [Key]
        [StringLength(50)]
        public string APPKEY { get; set; }

        [Required]
        [StringLength(100)]
        public string APPSECRET { get; set; }

        [Required]
        [StringLength(50)]
        public string ACCOUNT { get; set; }

        public bool DISABLED { get; set; }
    }
}
