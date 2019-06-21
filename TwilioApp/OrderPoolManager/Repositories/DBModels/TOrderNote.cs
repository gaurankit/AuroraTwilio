using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tOrderNote", Schema = "dbo")]
    public partial class TOrderNote
    {
        [Column("tOrderNoteID")]
        public int TOrderNoteId { get; set; }
        [Column("OrderID")]
        public int OrderId { get; set; }
        [Required]
        public string OrderNote { get; set; }
        [Required]
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreateDate { get; set; }
        public int? OrderNoteCategoryId { get; set; }
        [StringLength(64)]
        public string DispositionSessionId { get; set; }

        [ForeignKey("OrderId")]
        [InverseProperty("TOrderNote")]
        public TOrder Order { get; set; }
        [ForeignKey("OrderNoteCategoryId")]
        [InverseProperty("TOrderNote")]
        public TOrderNoteCategory OrderNoteCategory { get; set; }
    }
}
