namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OWCRPT")]
    public partial class OWCRPT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string RID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ROWID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int COLID { get; set; }

        public int? WrapText { get; set; }

        [StringLength(1000)]
        public string FORMULA { get; set; }

        [StringLength(100)]
        public string NumberFormatLocal { get; set; }

        public int? MergeAreaRow { get; set; }

        public int? MergeAreaColumn { get; set; }

        public int? MergeAreaRowsCount { get; set; }

        public int? MergeAreaColumnCount { get; set; }

        public int? FontBold { get; set; }

        [StringLength(50)]
        public string FontName { get; set; }

        public int? FontSize { get; set; }

        public int? FontItalic { get; set; }

        [StringLength(20)]
        public string FontFontStyle { get; set; }

        public int? FontColorIndex { get; set; }

        public int? FontUnderline { get; set; }

        public int? HorizontalAlignment { get; set; }

        public int? VerticalAlignment { get; set; }

        public int? BordersxlEdgeLeftLineStyle { get; set; }

        public int? BordersxlEdgeLeftWeight { get; set; }

        public int? BordersxlEdgeLeftColorIndex { get; set; }

        public int? BordersxlEdgeTopLineStyle { get; set; }

        public int? BordersxlEdgeTopWeight { get; set; }

        public int? BordersxlEdgeTopColorIndex { get; set; }

        public int? BordersxlEdgeBottomLineStyle { get; set; }

        public int? BordersxlEdgeBottomWeight { get; set; }

        public int? BordersxlEdgeBottomColorIndex { get; set; }

        public int? BordersxlEdgeRightLineStyle { get; set; }

        public int? BordersxlEdgeRightWeight { get; set; }

        public int? BordersxlEdgeRightColorIndex { get; set; }

        public decimal? ColumnWidth { get; set; }

        public int? InteriorColorIndex { get; set; }

        public int? InteriorPattern { get; set; }

        public int? DisplayGridlines { get; set; }

        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime? CREATED { get; set; }
    }
}
