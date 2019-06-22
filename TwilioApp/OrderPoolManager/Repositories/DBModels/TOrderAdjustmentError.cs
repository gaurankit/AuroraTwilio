using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tOrderAdjustmentError", Schema = "dbo")]
    public partial class TOrderAdjustmentError
    {
        [Key]
        [Column("OrderAdjustmentErrorID")]
        public int OrderAdjustmentErrorId { get; set; }
        [Column("OrderAdjustmentID")]
        public int OrderAdjustmentId { get; set; }
        [StringLength(50)]
        public string OrderAdjustmentErrorCode { get; set; }
        [StringLength(2000)]
        public string OrderAdjustmentErrorDescription { get; set; }
        [Required]
        [StringLength(50)]
        public string OrderAdjustmentErrorCreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime OrderAdjustmentErrorCreateDate { get; set; }

        [ForeignKey("OrderAdjustmentId")]
        [InverseProperty("TOrderAdjustmentError")]
        public TOrderAdjustment OrderAdjustment { get; set; }
    }
}
