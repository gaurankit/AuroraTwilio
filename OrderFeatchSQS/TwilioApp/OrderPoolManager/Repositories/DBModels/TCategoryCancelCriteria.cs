using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tCategoryCancelCriteria", Schema = "dbo")]
    public partial class TCategoryCancelCriteria
    {
        [Key]
        [Column("CategoryCancelCriteriaID")]
        public int CategoryCancelCriteriaId { get; set; }
        [Column("OrderCategoryKeyID")]
        public int OrderCategoryKeyId { get; set; }
        [Column("OrderCategoryTypeID")]
        public int OrderCategoryTypeId { get; set; }
        public bool IsCancellable { get; set; }
        [Column(TypeName = "money")]
        public decimal CancelFee { get; set; }
        [Column(TypeName = "money")]
        public decimal CancelFeeForeignCurrency { get; set; }
        [Column(TypeName = "datetimeoffset(0)")]
        public DateTimeOffset NoCancelFeeDate { get; set; }

        [ForeignKey("OrderCategoryKeyId")]
        [InverseProperty("TCategoryCancelCriteria")]
        public TOrderCategoryKey OrderCategoryKey { get; set; }
    }
}
