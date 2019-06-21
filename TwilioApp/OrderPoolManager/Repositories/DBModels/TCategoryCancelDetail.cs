using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderPoolManager.Repositories.DBModels
{
    [Table("tCategoryCancelDetail", Schema = "dbo")]
    public partial class TCategoryCancelDetail
    {
        public TCategoryCancelDetail()
        {
            TCategoryCancelDetailError = new HashSet<TCategoryCancelDetailError>();
            TOrderRefundFailureDetail = new HashSet<TOrderRefundFailureDetail>();
        }

        [Key]
        [Column("CategoryCancelDetailID")]
        public int CategoryCancelDetailId { get; set; }
        [Column("OrderCategoryKeyID")]
        public int OrderCategoryKeyId { get; set; }
        [Column("CategoryCancelDetailReasonTypeID")]
        public byte CategoryCancelDetailReasonTypeId { get; set; }
        [StringLength(100)]
        public string ProviderCancelCode { get; set; }
        [StringLength(100)]
        public string ConfirmationCode { get; set; }
        public bool? IsRefundable { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CancelFeeAppliesAfterDate { get; set; }
        [Required]
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreateDate { get; set; }
        [Column("ProviderID")]
        public int? ProviderId { get; set; }
        public bool IsCreditCardRefundNeeded { get; set; }

        [ForeignKey("CategoryCancelDetailReasonTypeId")]
        [InverseProperty("TCategoryCancelDetail")]
        public TCategoryCancelDetailReasonType CategoryCancelDetailReasonType { get; set; }
        [ForeignKey("OrderCategoryKeyId")]
        [InverseProperty("TCategoryCancelDetail")]
        public TOrderCategoryKey OrderCategoryKey { get; set; }
        [ForeignKey("ProviderId")]
        [InverseProperty("TCategoryCancelDetail")]
        public TProvider Provider { get; set; }
        [InverseProperty("CategoryCancelDetail")]
        public ICollection<TCategoryCancelDetailError> TCategoryCancelDetailError { get; set; }
        [InverseProperty("CategoryCancelDetail")]
        public ICollection<TOrderRefundFailureDetail> TOrderRefundFailureDetail { get; set; }
    }
}
