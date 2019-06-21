using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tOrderDetailConversion", Schema = "dbo")]
    public partial class TOrderDetailConversion
    {
        [Key]
        [Column("OrderDetailConversionID")]
        public int OrderDetailConversionId { get; set; }
        [Column("OrderDetailID")]
        public int OrderDetailId { get; set; }
        [Column("CategoryUID")]
        public Guid? CategoryUid { get; set; }
        [Column("RedemptionID")]
        public int? RedemptionId { get; set; }
        [Column("RedemptionRewardID")]
        public int? RedemptionRewardId { get; set; }
        [Column("OrderCategoryID")]
        public int? OrderCategoryId { get; set; }

        [ForeignKey("OrderDetailId")]
        [InverseProperty("TOrderDetailConversion")]
        public TOrderDetail OrderDetail { get; set; }
    }
}
