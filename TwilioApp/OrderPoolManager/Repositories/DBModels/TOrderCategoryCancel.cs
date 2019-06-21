using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tOrderCategoryCancel", Schema = "dbo")]
    public partial class TOrderCategoryCancel
    {
        public TOrderCategoryCancel()
        {
            TOrderCategoryCancelError = new HashSet<TOrderCategoryCancelError>();
        }

        [Key]
        [Column("OrderCategoryCancelID")]
        public int OrderCategoryCancelId { get; set; }
        [Column("OrderCategoryKeyID")]
        public int OrderCategoryKeyId { get; set; }
        [Column("OrderCategoryCancelReasonID")]
        public byte OrderCategoryCancelReasonId { get; set; }
        [Column(TypeName = "money")]
        public decimal AgentInvolvementFee { get; set; }
        [Column(TypeName = "money")]
        public decimal PointsRefunded { get; set; }
        [Column(TypeName = "money")]
        public decimal PurchasePriceRefunded { get; set; }
        [Column(TypeName = "money")]
        public decimal ProviderCancellationFee { get; set; }
        [Required]
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreateDate { get; set; }
        [StringLength(100)]
        public string ProviderCancellationCode { get; set; }
        [StringLength(100)]
        public string ConfirmationCode { get; set; }

        [ForeignKey("OrderCategoryCancelReasonId")]
        [InverseProperty("TOrderCategoryCancel")]
        public TOrderCategoryCancelReason OrderCategoryCancelReason { get; set; }
        [ForeignKey("OrderCategoryKeyId")]
        [InverseProperty("TOrderCategoryCancel")]
        public TOrderCategoryKey OrderCategoryKey { get; set; }
        [InverseProperty("OrderCategoryCancel")]
        public ICollection<TOrderCategoryCancelError> TOrderCategoryCancelError { get; set; }
    }
}
