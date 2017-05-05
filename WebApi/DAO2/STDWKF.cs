namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("STDWKF")]
    public partial class STDWKF
    {
        [Key]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        public decimal STDWRK { get; set; }

        public decimal STDWRKRATE { get; set; }

        public decimal STDWRK2 { get; set; }

        public decimal STDWRK2RATE { get; set; }

        public decimal? STDLABORCOST { get; set; }

        public decimal? STDFACOVRHAD { get; set; }

        public decimal? STDFUELCOST { get; set; }

        public decimal? STDMATCOST { get; set; }
    }
}
