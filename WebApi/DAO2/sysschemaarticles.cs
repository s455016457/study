namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysschemaarticles
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int artid { get; set; }

        [StringLength(255)]
        public string creation_script { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [Key]
        [Column(Order = 1)]
        public string dest_object { get; set; }

        [Key]
        [Column(Order = 2)]
        public string name { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int objid { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pubid { get; set; }

        [Key]
        [Column(Order = 5)]
        public byte pre_creation_cmd { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int status { get; set; }

        [Key]
        [Column(Order = 7)]
        public byte type { get; set; }

        [MaxLength(8)]
        public byte[] schema_option { get; set; }

        [StringLength(128)]
        public string dest_owner { get; set; }
    }
}
